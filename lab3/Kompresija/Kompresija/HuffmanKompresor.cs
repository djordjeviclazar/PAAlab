using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompresija
{
    public class HuffmanKompresor : IKompresor
    {
        public string Dekompresija(string kompresovanFajl, string fajl, String kodnaTabela)
        {
            Stopwatch stopwatch = new Stopwatch();
            string tekst = "";
            List<char> karakteriTeksta = new List<char>();
            string kompresovanTekst = "";
            Dictionary<string, char> tabela = new Dictionary<string, char>();

            #region Čitanje fajla

            using (StreamReader stream = new StreamReader(kompresovanFajl)) { kompresovanTekst = stream.ReadToEnd(); }
            using(StreamReader stream = new StreamReader(kodnaTabela))
            {
                while (!stream.EndOfStream)
                {
                    string pom = stream.ReadLine();
                    if (String.IsNullOrEmpty(pom)) { continue; }
                    char ključ = pom[0];
                    pom = stream.ReadLine();
                    if (String.IsNullOrEmpty(pom)) { continue; }
                    tabela.Add(pom, ključ); // obrnut redosled za dekompresiju
                }
            }

            #endregion Čitanje fajla

            stopwatch.Start();

            #region Dekompresija

            string kod = "";
            for (int i = 0; i < kompresovanTekst.Length; i++)
            {
                kod = kod + kompresovanTekst[i].ToString();
                if (tabela.ContainsKey(kod))
                {
                    string slovo;
                    tabela.TryGetValue(kod, out char p);
                    slovo = p.ToString();
                    tekst = tekst + slovo;
                    kod = "";
                }
            }

            #endregion Dekompresija

            #region Upis u fajl

            using(StreamWriter stream = new StreamWriter(fajl)) { stream.Write(tekst); }
            using(StreamWriter stream =  new StreamWriter(kodnaTabela))
            {
                foreach (var item in tabela)
                {
                    stream.WriteLine(item.Key);
                    stream.WriteLine(item.Value);
                }
            }

            #endregion Upis u fajl

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds + "";
        }

        public string Kompresija(string fajl, string kompresovanFajl, String kodnaTabela)
        {
            Stopwatch stopwatch = new Stopwatch();
            string tekst;
            Karakter kodnoStablo;
            List<char> karakteriTeksta = new List<char>();
            string kompresovanTekst = "";

            #region Čitanje fajla

            using (StreamReader stream = new StreamReader(fajl)) { tekst = stream.ReadToEnd(); }

            #endregion Čitanje fajla

            stopwatch.Start();

            #region Kodno stablo

            Karakter[] brojač = new Karakter[256];
            byte kod = 0;
            while (true)
            {
                brojač[kod] = new Karakter(kod);

                if (kod == byte.MaxValue) { break; }
                else { kod++; }
            }

            byte[] asciiKodovi = Encoding.ASCII.GetBytes(tekst);
            foreach (var a in asciiKodovi)
            {
                brojač[a].brojPojavljivanja++;
                karakteriTeksta.Add(Convert.ToChar(brojač[a].asciiKod));
            }
            Karakter[] heap = new Karakter[256];
            int brojElemenata = 0;
            for (int i = 0; i < 256; i++)
            {
                if (brojač[i].brojPojavljivanja > 0)
                {
                    heap[brojElemenata++] = brojač[i];
                }
            }
            
            // pravljenje heap-a
            for (int i = (brojElemenata - 1) / 2; i >= 0; i--)
            {
                DownHeap(ref heap, i, brojač.Length - 1, false);
            }

            while (brojElemenata > 1)
            {
                Karakter desni = new Karakter(heap[0]);
                heap[0] = new Karakter(heap[brojElemenata - 1]);
                brojElemenata--;
                DownHeap(ref heap, 0, brojElemenata - 1, false);

                Karakter levi = new Karakter(heap[0]);
                heap[0] = new Karakter(heap[brojElemenata - 1]);
                brojElemenata--;
                DownHeap(ref heap, 0, brojElemenata - 1, false);

                Karakter stablo = new Karakter(0, levi, desni, desni.brojPojavljivanja + levi.brojPojavljivanja);
                heap[brojElemenata++] = stablo;
                UpHeap(ref heap, brojElemenata - 1, false);
            }

            if (brojElemenata < 1 || heap[0] == null) { return null; }
            kodnoStablo = heap[0];

            #endregion Kodno stablo

            #region Kodna tabela

            Dictionary<char, string> tabela = new Dictionary<char, string>();
            GenerisanjeKodneTabele(tabela, "", kodnoStablo);

            #endregion Kodna tabela

            #region Kompresija

            for (int i = 0; i < tekst.Length; i++)
            {
                tabela.TryGetValue(tekst[i], out string k);
                kompresovanTekst = kompresovanTekst + k;
            }

            #endregion

            #region Upis u fajl

            using (StreamWriter stream = new StreamWriter(kompresovanFajl))
            {
                stream.Write(kompresovanTekst);
            }

            Dictionary<string, char> tabela2 = new Dictionary<string, char>();
            foreach (var k in karakteriTeksta)
            {
                tabela.TryGetValue(k, out string kodKaraktera);
                if (!tabela2.ContainsKey(kodKaraktera))
                    tabela2.Add(kodKaraktera, k);
            }

            string kod2 = "";
            string tekst2 = "";
            for (int i = 0; i < kompresovanTekst.Length; i++)
            {
                kod2 = kod2 + kompresovanTekst[i].ToString();
                if (tabela2.ContainsKey(kod2))
                {
                    string slovo;
                    tabela2.TryGetValue(kod2, out char p);
                    
                    slovo = p.ToString();
                    tekst2 = tekst2 + slovo;
                    kod2 = "";
                }
            }
            int nepoklapanje = -1;
            char t1, t2;
            int sub = tekst.Length - tekst2.Length;
            for (int i = 0; i < tekst.Length;i++)
            {
                if (tekst[i] != tekst2[i])
                {
                    nepoklapanje = i;
                    t1 = tekst[i];
                    t2 = tekst[i];
                    break;
                }
            }
            /*using (StreamWriter stream = new StreamWriter(kodnaTabela))
            {
                foreach (var item in tabela)
                {
                    stream.WriteLine(item.Key);
                    stream.WriteLine(item.Value);
                }
            }*/

            // dekompresija proba:

            #endregion Upis u fajl

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds + "";
        }

        void GenerisanjeKodneTabele(Dictionary<char, string> tabela, string kod,Karakter čvor)
        {
            if (čvor.desno == null && čvor.levo == null)
            {
                tabela.Add(Convert.ToChar(čvor.asciiKod), kod);
            }
            else
            {
                GenerisanjeKodneTabele(tabela, kod + "0", čvor.levo);
                GenerisanjeKodneTabele(tabela, kod + "1", čvor.desno);
            }
        }

        void UpHeap(ref Karakter[] heap, int ind, bool maxHeap)
        {
            while (ind > 0)
            {
                int k = (ind + 1) / 2;
                k--;

                int c = heap[ind].CompareTo(heap[k]);
                if ((c > 0 && !maxHeap) || (c < 0 && maxHeap))
                {
                    return;
                }

                Karakter p = heap[ind];
                heap[ind] = heap[k];
                heap[k] = p;
                ind = k;
            }
        }

        void DownHeap(ref Karakter[] heap, int ind, int lastElement, bool maxHeap)
        {
            while (ind < lastElement)
            {
                int k = (ind + 1) * 2;
                if (k - 1 > lastElement) { return; }
                if (k - 1 == lastElement)
                {
                    int comp = heap[ind].CompareTo(heap[k - 1]);
                    if ((comp < 0 && maxHeap) || (comp > 0 && !maxHeap))
                    {
                        Karakter pom = heap[ind];
                        heap[ind] = heap[k - 1];
                        heap[k - 1] = pom;
                    }
                    return;
                }

                int c1 = heap[ind].CompareTo(heap[k - 1]);
                int c2 = heap[ind].CompareTo(heap[k]);
                if ((c1 > 0 && c2 > 0 && maxHeap) || (c1 < 0 && c2 < 0 && !maxHeap))
                {
                    return;
                }

                if (heap[k] == null || heap[k-1] == null) { return; }
                Karakter p = heap[ind];
                int c3 = heap[k].CompareTo(heap[k - 1]);
                if ((maxHeap && c3 > 0) || (!maxHeap && c3 < 0))
                {
                    heap[ind] = heap[k];
                    heap[k] = p;
                    ind = k;
                }
                else
                {
                    heap[ind] = heap[k - 1];
                    heap[k - 1] = p;
                    ind = k - 1;
                }
            }
        }

        private class Karakter : IComparable
        {
            public byte asciiKod;
            public int brojPojavljivanja;
            public Karakter levo, desno;

            public Karakter()
            {
                asciiKod = 0;
                levo = null;
                desno = null;
                brojPojavljivanja = 0;
            }

            public Karakter(Karakter karakter)
            {
                asciiKod = karakter.asciiKod;
                levo = karakter.levo;
                desno = karakter.desno;
                brojPojavljivanja = karakter.brojPojavljivanja;
            }

            public Karakter(byte kod, Karakter levi = null, Karakter desni = null, int brojPojavljivanja = 0)
            {
                this.asciiKod = kod;
                this.levo = levi;
                this.desno = desni;
                this.brojPojavljivanja = brojPojavljivanja;
            }

            public int CompareTo(object obj)
            {
                if (this == null && obj == null) { return 0; }
                if (this == null) { return -1; }
                if (obj == null) { return 1; }
                if (obj is Karakter karakter)
                {
                    return this.brojPojavljivanja - karakter.brojPojavljivanja;
                }

                return -1;
            }
        }
    }
}
