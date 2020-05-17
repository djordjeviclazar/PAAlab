using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBstabla
{
    public class RBstablo
    {
        private Čvor koren;
        private int brojElemenata;

        public RBstablo()
        {
            koren = null;
            brojElemenata = 0;
        }

        public string Pretraga(int ključ, out bool izvršenaOperacija, out int element, out object obj)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            izvršenaOperacija = false;
            Čvor t = koren;
            element = -1;
            obj = null;
            while (t != null)
            {
                if (t.ključ == ključ)
                {
                    element = t.ključ;
                    obj = t.obj;
                    izvršenaOperacija = true;
                    break;
                }

                if (ključ < t.ključ)
                {
                    t = t.levo;
                    continue;
                }
                else
                {
                    t = t.desno;
                    continue;
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds + "";
        }

        public string Dodaj(int ključ, object obj)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            koren = DodajČvor(koren, ključ, obj);
            brojElemenata++;

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds + "";
        }

        private Čvor DodajČvor(Čvor čvor, int noviKljuč, object noviElement)
        {
            if (čvor == null) { return new Čvor(noviKljuč, noviElement); }

            if (čvor.ključ == noviKljuč) { čvor.obj = noviElement; }
            else
            {
                if (čvor.ključ > noviKljuč) { čvor.desno = DodajČvor(čvor.desno, noviKljuč, noviElement); }
                else { čvor.levo = DodajČvor(čvor.levo, noviKljuč, noviElement); }
            }

            // provera uslova:
            if ((čvor.desno != null && čvor.desno.crven) && (čvor.levo == null || !čvor.levo.crven)) 
                { čvor = čvor.RotirajLevo(); }
            if ((čvor.levo != null && čvor.levo.crven) && (čvor.levo.levo != null && čvor.levo.levo.crven)) 
                { čvor = čvor.RotirajDesno(); }
            if ((čvor.levo != null && čvor.levo.crven) && (čvor.desno != null && čvor.desno.crven))
                { čvor.PromeniBoje(); }

            return čvor;
        }

        public string Brisanje(int ključ, out bool uspešnaOperacija)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            koren = BrišiČvor(koren, ključ, out uspešnaOperacija);

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds + "";
        }

        private Čvor BrišiČvor(Čvor čvor, int noviKljuč, out bool uspešnaOperacija)
        {
            if (čvor == null)
            {
                uspešnaOperacija = false;
                return null;
            }

            if (čvor.ključ == noviKljuč) 
            {
                čvor.obj = noviElement; 
            }
            else
            {
                if (čvor.ključ > noviKljuč) 
                { 
                    čvor.desno = DodajČvor(čvor.desno, noviKljuč, noviElement); 
                }
                else 
                {
                    čvor.levo = DodajČvor(čvor.levo, noviKljuč, noviElement); 
                }
            }
        }

        class Čvor
        {
            internal int ključ;
            internal object obj;
            internal Čvor levo, desno;
            internal bool crven;

            internal Čvor()
            {
                crven = false;
                obj = null;
                levo = null;
                desno = null;
                ključ = default;
            }

            internal Čvor(int ključ, object obj = null)
            {
                crven = false;
                this.obj = obj;
                levo = null;
                desno = null;
                this.ključ = ključ;
            }

            internal void PromeniBoje()
            {
                this.crven = true;
                this.desno.crven = false;
                this.levo.crven = false;
            }

            internal Čvor RotirajLevo()
            {
                Čvor pom = this.desno;

                this.desno = pom.levo;

                pom.levo = this;

                pom.crven = this.crven;
                this.crven = true;

                return pom;
            }

            internal Čvor RotirajDesno()
            {
                Čvor pom = this.levo;

                this.levo = pom.desno;

                pom.desno = this;

                pom.crven = this.crven;
                this.crven = true;

                return pom;
            }
        }
    }
}
