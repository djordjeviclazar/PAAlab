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
            koren.crven = false;
            brojElemenata++;

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds + "";
        }

        private Čvor DodajČvor(Čvor čvor, int noviKljuč, object noviElement)
        {
            if (čvor == null) { return new Čvor(noviKljuč, noviElement) { crven = true }; }

            if (čvor.ključ == noviKljuč) { čvor.obj = noviElement; }
            else
            {
                if (čvor.ključ <= noviKljuč) { čvor.desno = DodajČvor(čvor.desno, noviKljuč, noviElement); }
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

            if (koren != null && koren.levo != null && koren.desno != null && !koren.levo.crven && !koren.desno.crven)
            {
                koren.crven = true;
            }
            koren = BrišiČvor(koren, ključ, out uspešnaOperacija);
            if (uspešnaOperacija) { brojElemenata--; }
            if (koren != null)
            {
                koren.crven = false;
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds + "";
        }

        private Čvor BrišiČvor(Čvor čvor, int ključ, out bool uspešnaOperacija)
        {
            if (čvor == null)
            {
                uspešnaOperacija = false;
                return null;
            }

            if (čvor.ključ > ključ)
            {
                if ((čvor.levo != null && čvor.levo.levo != null) && (!čvor.levo.crven && !čvor.levo.levo.crven))
                {
                    čvor = SpojiLevo(čvor);
                }
                čvor.levo = BrišiČvor(čvor.levo, ključ, out uspešnaOperacija);
            }
            else
            {
                if (čvor.levo != null && čvor.levo.crven)
                {
                    čvor = čvor.RotirajDesno();
                }
                if (ključ == čvor.ključ && čvor.desno == null)
                {
                    uspešnaOperacija = true;
                    return null;
                }
                if ((čvor.desno != null && čvor.desno.levo != null) && !čvor.desno.crven && !čvor.desno.levo.crven)
                {
                    čvor = SpojiDesno(čvor);
                }
                if (čvor.ključ == ključ)
                {
                    Čvor pom = Min(čvor.desno);
                    čvor.ključ = pom.ključ;
                    čvor.obj = pom.obj;
                    čvor.desno = BrišiMin(čvor.desno);

                    uspešnaOperacija = true;
                }
                else
                {
                    čvor.desno = BrišiČvor(čvor.desno, ključ, out uspešnaOperacija);
                }
            }

            // provera uslova:
            if (čvor != null)
            {
                if ((čvor.desno != null && čvor.desno.crven) && (čvor.levo == null || !čvor.levo.crven))
                { čvor = čvor.RotirajLevo(); }
                if ((čvor.levo != null && čvor.levo.crven) && (čvor.levo.levo != null && čvor.levo.levo.crven))
                { čvor = čvor.RotirajDesno(); }
                if ((čvor.levo != null && čvor.levo.crven) && (čvor.desno != null && čvor.desno.crven))
                { čvor.PromeniBoje(); }
            }

            return čvor;
        }

        private Čvor BrišiMin(Čvor čvor)
        {
            if (čvor.levo == null) { return null; }

            if ((čvor.levo != null && čvor.levo.levo != null) && (!čvor.levo.crven && !čvor.levo.levo.crven))
            {
                čvor = SpojiLevo(čvor);
            }

            čvor.levo = BrišiMin(čvor.levo);

            // provera uslova:
            if ((čvor.desno != null && čvor.desno.crven) && (čvor.levo == null || !čvor.levo.crven))
            { čvor = čvor.RotirajLevo(); }
            if ((čvor.levo != null && čvor.levo.crven) && (čvor.levo.levo != null && čvor.levo.levo.crven))
            { čvor = čvor.RotirajDesno(); }
            if ((čvor.levo != null && čvor.levo.crven) && (čvor.desno != null && čvor.desno.crven))
            { čvor.PromeniBoje(); }

            return čvor;
        }

        private Čvor Min(Čvor čvor)
        {
            if (čvor.levo == null) { return čvor; }
            else { return Min(čvor.levo); }
        }

        private Čvor SpojiLevo(Čvor čvor)
        {
            čvor.PromeniBoje();
            if (čvor.desno != null && čvor.desno.levo != null && čvor.desno.levo.crven)
            {
                // Dva crvena čvora za redom
                čvor.desno = čvor.desno.RotirajDesno();
                čvor = čvor.RotirajLevo();
                čvor.PromeniBoje();
            }
            return čvor;
        }

        private Čvor SpojiDesno(Čvor čvor)
        {
            čvor.PromeniBoje();
            if (čvor.desno != null && čvor.desno.levo != null && čvor.desno.levo.crven)
            {
                čvor = čvor.RotirajDesno();
                čvor.PromeniBoje();
            }
            return čvor;
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
                this.crven = !this.crven;
                this.desno.crven = !this.desno.crven;
                this.levo.crven = !this.levo.crven;
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
