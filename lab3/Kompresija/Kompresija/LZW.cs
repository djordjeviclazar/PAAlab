using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Collections;

namespace Kompresija
{
    public class LZW : IKompresor
    {
        public string Dekompresija(string kompresovanFajl, string fajl, string kodnaTabela)
        {
            Stopwatch stopwatch = new Stopwatch();
            string tekst = "";
            Dictionary<int, string> tabela = new Dictionary<int, string>();
            List<string> rezultat = new List<string>();
            char brojac = (char)0;
            while (brojac < 256)
            {
                tabela.Add(Convert.ToInt32(brojac), brojac.ToString());
                brojac++;
            }

            #region Čitanje fajla
            FileStream fStream = File.Open(kompresovanFajl, FileMode.Open);
            using (BinaryReader stream = new BinaryReader(fStream))
            {
                
                for (long i = 0; i < fStream.Length; i += 4)
                {
                    int bajtovi = stream.ReadInt32();
                    char[] bitovi = new Char[32];
                    for (int k = 31; k >= 0; k--)
                    {
                        if (bajtovi % 2 == 0) { bitovi[k] = '0'; }
                        else { bitovi[k] = '1'; }
                        bajtovi = bajtovi >> 1;
                    }
                    string stringBitova = new String(bitovi);
                    tekst = tekst + stringBitova;
                }
            }

            #endregion Čitanje fajla

            stopwatch.Start();

            #region Deompresija

            string dvaBajta = tekst.Substring(0, 32);
            //ushort.TryParse(dvaBajta, out ushort kod);
            int kod = Convert.ToInt32(dvaBajta, 2);
            tabela.TryGetValue(kod, out string karakter);
            rezultat.Add(karakter);
            string word = karakter;

            int poslednjiKod = 256;
            for (int i = 32; i < tekst.Length; i += 32)
            {
                string dWord;
                int substringLength = 32;

                if (i + 32 > tekst.Length) { substringLength = tekst.Length - i; }
                dvaBajta = tekst.Substring(i, substringLength);
                //ushort.TryParse(dvaBajta, out kod);
                kod = Convert.ToInt32(dvaBajta, 2);

                if (tabela.ContainsKey(kod) && i < (tekst.Length - 1))
                {
                    tabela.TryGetValue(kod, out dWord);
                    rezultat.Add(dWord);
                    tabela.Add(poslednjiKod++, word + dWord[0]);
                    word = dWord;
                }
                else
                {
                    dWord = word + word[0];
                    tabela.Add(poslednjiKod++, dWord);
                    word = dWord;
                }
            }

            #endregion Dekompresija

            #region Pisanje u fajl

            using (StreamWriter stream = new StreamWriter(fajl)) 
            {
                foreach(var a in rezultat)
                {
                    stream.Write(a);
                }
            }

            using (StreamWriter stream = new StreamWriter(kodnaTabela))
            {
                foreach (var a in tabela)
                {
                    stream.WriteLine(a.Value);
                    stream.WriteLine(a.Key);
                }
            }

            #endregion Pisanje u fajl

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds + "";
        }

        public string Kompresija(string fajl, string kompresovanFajl, string kodnaTabela)
        {
            Stopwatch stopwatch = new Stopwatch();
            string tekst;
            Dictionary<string, int> tabela = new Dictionary<string, int>();
            List<int> rezultat = new List<int>();
            char brojac = (char)0;
            while (brojac < 256)
            {
                tabela.Add(brojac.ToString(), Convert.ToInt32(brojac));
                brojac++;

            }

            #region Čitanje fajla

            using (StreamReader stream = new StreamReader(fajl)) { tekst = stream.ReadToEnd(); }

            #endregion Čitanje fajla

            stopwatch.Start();

            #region Kompresija

            string word = "";
            ushort poslednjiKod = 256;
            for (int i = 0; i < tekst.Length; i++)
            {
                string newWord = word + tekst[i].ToString();
                if (tabela.ContainsKey(newWord))
                {
                    word = newWord;
                }
                else
                {
                    tabela.Add(newWord, poslednjiKod++);
                    tabela.TryGetValue(word, out int kod);
                    rezultat.Add(kod);
                    word = tekst[i].ToString();
                }
            }

            #endregion Kompresija

            #region Pisanje u fajl

            using (BinaryWriter stream = new BinaryWriter(File.Open(kompresovanFajl, FileMode.Create)))
            {
                foreach (var a in rezultat)
                {
                    stream.Write(a);
                }
            }

            using (StreamWriter stream = new StreamWriter(kodnaTabela))
            {
                foreach (var a in tabela)
                {
                    stream.WriteLine(a.Key);
                    int vrednost = a.Value;
                    string vrednostBitovi = new string('n', 32);
                    char[] karakteriBroja = vrednostBitovi.ToCharArray();
                    for (int i = 31; i >= 0; i--)
                    {
                        if (vrednost % 2 == 0) { karakteriBroja[i] = '0'; }
                        else { karakteriBroja[i] = '1'; }
                        vrednost = vrednost >> 1;
                    }
                    vrednostBitovi = new string(karakteriBroja);
                    stream.WriteLine(vrednostBitovi);
                }
            }

            #endregion Pisanje u fajl

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds + "";
        }
    }
}
