using Sortiranje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBstabla
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            RBstablo rb;
            Random random = new Random();
            string vreme;
            // int[] niz;
            int br, p, t;
            bool pom;


            Console.WriteLine("RB stablo \r\n");

            #region Test 10 el

            Console.WriteLine("Test 10 elemenata\n");
            Console.WriteLine("------------------------");

            br = 10;
            //sort.RandomNiz(br, out niz, "");
            int[] niz = { 5, 15, 2, 1, 0, 22, 3, 4, 7, 11};
            rb = new RBstablo();

            // Kreiranje
            Console.WriteLine("Kreiranje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br; i++)
            {
                vreme = rb.Dodaj(niz[i], null);
                Console.WriteLine(i + ") vreme = " + vreme);
            }

            // Brisanje 10% elemenata
            Console.WriteLine("Brisanje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                vreme = rb.Brisanje(15, out pom);
                Console.WriteLine(i + ") vreme = " + vreme + "\t uspeh: " + pom);
            }

            // Pretraga 10% elemenata
            Console.WriteLine("Pretraga:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                t = random.Next(0, 10000);
                vreme = rb.Pretraga(0, out pom, out p, out _);
                Console.WriteLine(i + ") vreme = " + vreme + "\t uspeh: " + (pom && (p == t)));
            }

            // Dodavanje 10% elemenata
            Console.WriteLine("Dodavanje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                t = random.Next(0, 10000);
                vreme = rb.Dodaj(t, null);
                Console.WriteLine(i + ") vreme = " + vreme);
            }

            Console.WriteLine("------------------------");

            #endregion

            #region Test 100 el

            Console.WriteLine("Test 100 elemenata\n");
            Console.WriteLine("------------------------");

            br = 100;
            sort.RandomNiz(br, out niz, "");
            rb = new RBstablo();

            // Kreiranje
            Console.WriteLine("Kreiranje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br; i++)
            {
                vreme = rb.Dodaj(niz[i], null);
                Console.WriteLine(i + ") vreme = " + vreme);
            }

            // Brisanje 10% elemenata
            Console.WriteLine("Brisanje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                vreme = rb.Brisanje(random.Next(0, 10000), out pom);
                Console.WriteLine(i + ") vreme = " + vreme + "\t uspeh: " + pom);
            }

            // Pretraga 10% elemenata
            Console.WriteLine("Pretraga:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                t = random.Next(0, 10000);
                vreme = rb.Pretraga(t, out pom, out p, out _);
                Console.WriteLine(i + ") vreme = " + vreme + "\t uspeh: " + (pom && (p == t)));
            }

            // Dodavanje 10% elemenata
            Console.WriteLine("Dodavanje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                t = random.Next(0, 10000);
                vreme = rb.Dodaj(t, null);
                Console.WriteLine(i + ") vreme = " + vreme);
            }

            Console.WriteLine("------------------------");

            #endregion

            #region Test 1K el

            Console.WriteLine("Test 1K elemenata\n");
            Console.WriteLine("------------------------");

            br = 1000;
            sort.RandomNiz(br, out niz, "");
            rb = new RBstablo();

            // Kreiranje
            Console.WriteLine("Kreiranje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br; i++)
            {
                vreme = rb.Dodaj(niz[i], null);
                Console.WriteLine(i + ") vreme = " + vreme);
            }

            // Brisanje 10% elemenata
            Console.WriteLine("Brisanje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                vreme = rb.Brisanje(random.Next(0, 10000), out pom);
                Console.WriteLine(i + ") vreme = " + vreme + "\t uspeh: " + pom);
            }

            // Pretraga 10% elemenata
            Console.WriteLine("Pretraga:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                t = random.Next(0, 10000);
                vreme = rb.Pretraga(t, out pom, out p, out _);
                Console.WriteLine(i + ") vreme = " + vreme + "\t uspeh: " + (pom && (p == t)));
            }

            // Dodavanje 10% elemenata
            Console.WriteLine("Dodavanje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                t = random.Next(0, 10000);
                vreme = rb.Dodaj(t, null);
                Console.WriteLine(i + ") vreme = " + vreme);
            }

            Console.WriteLine("------------------------");

            #endregion

            #region Test 10K el

            Console.WriteLine("Test 10K elemenata\n");
            Console.WriteLine("------------------------");

            br = 10000;
            sort.RandomNiz(br, out niz, "");
            rb = new RBstablo();

            // Kreiranje
            Console.WriteLine("Kreiranje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br; i++)
            {
                vreme = rb.Dodaj(niz[i], null);
                Console.WriteLine(i + ") vreme = " + vreme);
            }

            // Brisanje 10% elemenata
            Console.WriteLine("Brisanje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                vreme = rb.Brisanje(random.Next(0, 10000), out pom);
                Console.WriteLine(i + ") vreme = " + vreme + "\t uspeh: " + pom);
            }

            // Pretraga 10% elemenata
            Console.WriteLine("Pretraga:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                t = random.Next(0, 10000);
                vreme = rb.Pretraga(t, out pom, out p, out _);
                Console.WriteLine(i + ") vreme = " + vreme + "\t uspeh: " + (pom && (p == t)));
            }

            // Dodavanje 10% elemenata
            Console.WriteLine("Dodavanje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                t = random.Next(0, 10000);
                vreme = rb.Dodaj(t, null);
                Console.WriteLine(i + ") vreme = " + vreme);
            }

            Console.WriteLine("------------------------");

            #endregion

            #region Test 100K el

            Console.WriteLine("Test 100K elemenata\n");
            Console.WriteLine("------------------------");

            br = 100000;
            sort.RandomNiz(br, out niz, "");
            rb = new RBstablo();

            // Kreiranje
            Console.WriteLine("Kreiranje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br; i++)
            {
                vreme = rb.Dodaj(niz[i], null);
                Console.WriteLine(i + ") vreme = " + vreme);
            }

            // Brisanje 10% elemenata
            Console.WriteLine("Brisanje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                vreme = rb.Brisanje(random.Next(0, 10000), out pom);
                Console.WriteLine(i + ") vreme = " + vreme + "\t uspeh: " + pom);
            }

            // Pretraga 10% elemenata
            Console.WriteLine("Pretraga:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                t = random.Next(0, 10000);
                t = niz[t % 5000]; 
                vreme = rb.Pretraga(t, out pom, out p, out _);
                Console.WriteLine(i + ") vreme = " + vreme + "\t uspeh: " + (pom && (p == t)));
            }

            // Dodavanje 10% elemenata
            Console.WriteLine("Dodavanje:");
            Console.WriteLine("*******************");
            for (int i = 0; i < br / 10; i++)
            {
                t = random.Next(0, 10000);
                vreme = rb.Dodaj(t, null);
                Console.WriteLine(i + ") vreme = " + vreme);
            }

            Console.WriteLine("------------------------");

            #endregion

            Console.ReadLine();
        }
    }
}
