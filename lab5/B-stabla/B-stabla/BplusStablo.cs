using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_stabla
{
    public class BplusStablo
    {
        private Čvor koren;
        private int stepen;

        public BplusStablo()
        {
            koren = new Čvor();
            stepen = 3;
        }

        public BplusStablo(int stepen)
        {
            koren = new Čvor(stepen);
            this.stepen = stepen;

        }

        public string Pretraga(int ključ, out int element, out Object obj)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Čvor p = koren;
            int indeks;

            while (!p.terminal)
            {
                bool pom = p.NađiKljuč(ključ, out _, out indeks);

                if (pom || indeks > 0)
                {
                    p = pom ? p.ključ[indeks].potomak : p.ključ[indeks - 1].potomak;
                }
                else
                {
                    p = p.levo;
                }
            }
            if (p.NađiKljuč(ključ, out element, out indeks))
            {
                obj = p.ključ[indeks].obj;
            }
            else
            {
                obj = null;
                element = -1;
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds + "";
        }

        public string PretragaIntervala(int? početak, int? kraj, out List<int> rezultat)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int d = početak ?? 0, g = kraj ?? 10000;

            Čvor p = koren;
            int indeks;
            rezultat = new List<int>();

            while (!p.terminal)
            {
                bool pom = p.NađiKljuč(d, out _, out indeks);

                if (pom || indeks > 0)
                {
                    p = pom? p.ključ[indeks].potomak : p.ključ[indeks - 1].potomak;
                }
                else
                {
                    p = p.levo;
                }
            }
            if (p.NađiKljuč(d, out _, out indeks))
            {
                int rez = d;
                rezultat.Add(rez);
            }
            indeks++;
            do
            {
                for (int i = indeks; i < p.ključ.Length; i++)
                {
                    if (p.ključ[i].vrednost <= g)
                    {
                        int rez = p.ključ[i].vrednost;
                        rezultat.Add(rez);
                    }
                }

                p = p.desniSused;
                indeks = 0;
            } while (p != null);

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds + "";
        }

        public string Dodavanje(int ključ, Object obj = null)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Čvor p = koren;
            int indeks;
            Čvor[] nizRoditelja = new Čvor[1000];
            int[] nizIndeksa = new int[1000];
            int v = 0;
            bool noviKoren = true;

            while (!p.terminal)
            {
                bool pom = p.NađiKljuč(ključ, out _, out indeks);

                nizRoditelja[v] = p;

                if (pom || indeks > 0)
                {
                    p = pom ? p.ključ[indeks].potomak : p.ključ[indeks - 1].potomak;

                    nizIndeksa[v] = pom ? indeks : indeks - 1;

                }
                else
                {
                    p = p.levo;

                    nizIndeksa[v] = -1;
                }
                v++;
            }

            p.DodajKljuč(ključ);
            if (p.brojElemenata == stepen)
            {
                // cepanje:
                Čvor novi = new Čvor(stepen);
                int k = 0;
                for (int i = stepen >> 1; i < stepen; i++)
                {
                    novi.ključ[k++] = p.ključ[i];
                    novi.brojElemenata++;
                }
                p.brojElemenata -= novi.brojElemenata;

                novi.leviSused = p;
                novi.desniSused = p.desniSused;
                
                if (p.desniSused != null) { p.desniSused.leviSused = novi; }
                p.desniSused = novi;
                

                // dodavanje u roditeljski:
                Čvor t = novi;
                while (v > 0)
                {
                    v--;
                    nizRoditelja[v].DodajKljuč(t.ključ[0].vrednost);
                    if (nizRoditelja[v].ključ[nizIndeksa[v] + 1].potomak == null)
                    {
                        nizRoditelja[v].ključ[nizIndeksa[v] + 1].potomak = t;
                    }
                    else
                    {
                        throw new Exception("Jao ne");
                    }

                    if (nizRoditelja[v].ključ.Length < stepen)
                    {
                        noviKoren = false;
                        break;
                    }

                    // cepanje roditelja:
                    Čvor noviRoditelj = new Čvor(stepen);
                    Čvor roditelj = nizRoditelja[v];
                    k = 0;
                    for (int i = stepen >> 1; i < stepen; i++)
                    {
                        noviRoditelj.ključ[k++] = roditelj.ključ[i];
                        noviRoditelj.brojElemenata++;
                    }
                    roditelj.brojElemenata -= noviRoditelj.brojElemenata;

                    noviRoditelj.leviSused = roditelj;
                    noviRoditelj.desniSused = roditelj.desniSused;

                    if (roditelj.desniSused != null) { roditelj.desniSused.leviSused = noviRoditelj; }
                    roditelj.desniSused = noviRoditelj;

                    t = noviRoditelj;
                    noviKoren = true;
                }

                if (noviKoren)
                {
                    Čvor noviKorenStabla = new Čvor(stepen);
                    noviKorenStabla.levo = koren;
                    noviKorenStabla.ključ[0].potomak = t;
                    noviKorenStabla.ključ[0].vrednost = t.ključ[0].vrednost;
                    koren = noviKorenStabla;
                    koren.brojElemenata = 1;
                }

            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds + "";
        }

        public string Brisanje(int ključ)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Čvor p = koren;
            int indeks;
            Čvor[] nizRoditelja = new Čvor[1000];
            int[] nizIndeksa = new int[1000];
            int v = 0;
            //bool noviKoren = false;

            while (!p.terminal)
            {
                bool pom = p.NađiKljuč(ključ, out _, out indeks);

                nizRoditelja[v] = p;

                if (pom || indeks > 0)
                {
                    p = pom ? p.ključ[indeks].potomak : p.ključ[indeks - 1].potomak;

                    nizIndeksa[v] = pom ? indeks : indeks - 1;

                }
                else
                {
                    p = p.levo;

                    nizIndeksa[v] = -1;
                }
                v++;
            }

            while (v > 0)
            {

                int višak;
                p.ObrišiKljuč(ključ);
                if ((p.leviSused != null && p.leviSused.brojElemenata + p.brojElemenata < stepen) ||
                    (p.desniSused != null && p.desniSused.brojElemenata + p.brojElemenata < stepen))
                {
                    // spajanje:

                    Čvor sused = p.desniSused;
                    bool desni = true; ;
                    if (sused == null || (p.leviSused != null && p.leviSused.brojElemenata < sused.brojElemenata))
                    {
                        desni = false;
                        sused = p.leviSused;

                        višak = nizIndeksa[v - 1];

                        sused.desniSused = p.desniSused;
                        if (p.desniSused != null) { p.desniSused.leviSused = sused; }


                    }
                    else
                    {
                        višak = nizIndeksa[v - 1] + 1;

                        p.desniSused = sused.desniSused;
                        if (sused.desniSused != null) { sused.desniSused.leviSused = p; }
                    }
                    int k = p.brojElemenata - 1;
                    for (int i = 0; i < sused.brojElemenata; i++)
                    {
                        if (desni)
                        {
                            p.ključ[k++] = sused.ključ[i];
                            p.brojElemenata++;
                        }
                        else
                        {
                            sused.ključ[sused.brojElemenata] = p.ključ[i];
                            sused.brojElemenata++;
                        }
                    }


                    // brisanje iz roditeljskog:
                    Čvor trenutniRoditelj = nizRoditelja[v - 1];
                    if (desni)
                    {
                        if (višak >= trenutniRoditelj.brojElemenata)
                        {
                            // ključ se nalazi u susedu roditelja
                            trenutniRoditelj = trenutniRoditelj.desniSused;
                            višak = 0;
                        }

                        trenutniRoditelj.ključ = nizRoditelja[v - 1].ključ;
                        trenutniRoditelj.brojElemenata = nizRoditelja[v - 1].brojElemenata;
                    }

                    p = nizRoditelja[v - 1];
                    v--;
                }
                else
                {
                    break;
                }
            }
            

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds + "";
        }

        #region Ugnježdeni tipovi

        class Čvor
        {
            internal bool terminal;
            internal Ključ[] ključ;
            internal Čvor leviSused, desniSused, levo;
            internal int brojElemenata;

            internal Čvor()
            {
                leviSused = null;
                desniSused = null;
                levo = null;
                ključ = new Ključ[3];
                terminal = true;
                brojElemenata = 0;
            }

            internal Čvor(int n)
            {
                leviSused = null;
                desniSused = null;
                levo = null;
                ključ = new Ključ[n];
                terminal = true;
                brojElemenata = 0;
            }

            internal Čvor(Čvor čvor)
            {
                this.terminal = čvor.terminal;

                this.ključ = new Ključ[čvor.ključ.Length];
                for (int i = 0; i < čvor.ključ.Length; i++)
                {
                    this.ključ[i] = čvor.ključ[i];
                }

                leviSused = čvor.leviSused;
                desniSused = čvor.desniSused;
                levo = čvor.levo;
                brojElemenata = čvor.brojElemenata;
            }

            internal bool NađiKljuč(int ključ, out int element, out int indeks)
            {
                if(brojElemenata == 0) { element = -1; indeks = 0; return false; }

                int prvi = 0, poslednji = brojElemenata - 1, trenutni = 0;
                indeks = 0;
                element = -1;
                int pomBr = 0;

                while (prvi <= poslednji)
                {
                    if (pomBr > 0) { }
                    if (prvi == poslednji) { pomBr++; }
                    
                    trenutni = (prvi + poslednji) >> 1;
                    if (this.ključ[trenutni].vrednost > ključ)
                    {
                        prvi = trenutni;
                        continue;
                    }

                    if (this.ključ[trenutni].vrednost < ključ)
                    {
                        poslednji = trenutni;
                        continue;
                    }

                    element = this.ključ[trenutni].vrednost;
                    indeks = trenutni;
                    
                    return true;
                }

                int prethodnik = trenutni, naslednik = trenutni + 1;
                while (true)
                {
                    if (prethodnik < 0) { indeks = 0; break; }
                    if (naslednik >= this.brojElemenata) { indeks = this.brojElemenata - 1; break; }

                    if (this.ključ[prethodnik].vrednost <= ključ && this.ključ[naslednik].vrednost <= ključ)
                    {
                        prethodnik = naslednik++;
                        continue;
                    }
                    if (this.ključ[prethodnik].vrednost >= ključ && this.ključ[naslednik].vrednost >= ključ)
                    {
                        naslednik = prethodnik--;
                        continue;
                    }

                    if (this.ključ[prethodnik].vrednost <= ključ && this.ključ[naslednik].vrednost >= ključ)
                    {
                        indeks = naslednik;
                        break;
                    }
                }
                return false;
            }

            internal bool DodajKljuč(int ključ, Object obj = null)
            {
                if (brojElemenata == this.ključ.Length)
                {
                    return false;
                }

                NađiKljuč(ključ, out _, out int indeks);
                if (indeks == brojElemenata)
                {
                    this.ključ[indeks].IsNull = true;
                    this.ključ[indeks].vrednost = ključ;
                    this.ključ[indeks].obj = obj;
                    
                }
                else
                {
                    for (int i = brojElemenata; i > indeks; i--)
                    {
                        this.ključ[i] = this.ključ[i - 1];
                    }
                    this.ključ[indeks].vrednost = ključ;
                    this.ključ[indeks].obj = obj;
                    this.ključ[indeks].IsNull = true;
                }

                brojElemenata++;
                return true;
            }

            internal bool ObrišiKljuč(int ključ)
            {
                if (brojElemenata > 0 && NađiKljuč(ključ, out _, out int indeks))
                {
                    for (int i = indeks; i < brojElemenata; i++)
                    {
                        this.ključ[i] = this.ključ[i + 1];
                    }
                    brojElemenata--;
                    return true;
                }

                return false;
            }
        }

        struct Ključ
        {
            internal int vrednost;
            internal Object obj;
            internal Čvor potomak;
            internal bool isNull;

            public bool IsNull
            {
                get
                {
                    return isNull;
                }
                set
                {
                    if (value == false)
                    {
                        isNull = false;
                    }
                    else
                    {
                        isNull = true;
                        obj = null;
                        potomak = null;
                        vrednost = default(int);
                    }
                }
            }
        }
        #endregion
    }
}
