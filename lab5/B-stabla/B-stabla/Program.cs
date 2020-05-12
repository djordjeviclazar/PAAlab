using Sortiranje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_stabla
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Sort sort = new Sort();
            int[] niz;
            int brojProba;
            string prikaz;
            int pom;
            List<int> pom2;

            #region Test_Bplus_3

            BplusStablo bplus_3 = new BplusStablo(3);

            Console.WriteLine("\t\t Stepen 3 \n\n");

            #region Test_100_elemenata_stepen_3

            Console.WriteLine("Test sa 100 čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100 * 3, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 100 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1K_elemenata_stepen_3

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000 * 3, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 1000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_10K_elemenata_stepen_3

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(10000 * 3, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 10000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_100K_elemenata_stepen_3

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100000 * 3, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 100000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1M_elemenata_stepen_3

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000000 * 3, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 1000000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            Console.WriteLine("**********************");

            #endregion

            #region Test_Bplus_5

            BplusStablo bplus_5 = new BplusStablo(5);

            Console.WriteLine("\t\t Stepen 5 \n\n");

            #region Test_100_elemenata_stepen_5

            Console.WriteLine("Test sa 100 čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100 * 5, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_5.Dodavanje(niz[i]);
            }

            brojProba = 100 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1K_elemenata_stepen_5

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000 * 5, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_5.Dodavanje(niz[i]);
            }

            brojProba = 1000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_10K_elemenata_stepen_5

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(10000 * 5, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_5.Dodavanje(niz[i]);
            }

            brojProba = 10000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_100K_elemenata_stepen_5

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100000 * 5, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_5.Dodavanje(niz[i]);
            }

            brojProba = 100000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_5.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1M_elemenata_stepen_5

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000000 * 5, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 1000000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            Console.WriteLine("**********************");

            #endregion

            #region Test_Bplus_10

            BplusStablo bplus_10 = new BplusStablo(10);

            Console.WriteLine("\t\t Stepen 10 \n\n");

            #region Test_100_elemenata_stepen_10

            Console.WriteLine("Test sa 100 čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100 * 10, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_10.Dodavanje(niz[i]);
            }

            brojProba = 100 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1K_elemenata_stepen_10

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000 * 10, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_10.Dodavanje(niz[i]);
            }

            brojProba = 1000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_10K_elemenata_stepen_10

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(10000 * 10, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_10.Dodavanje(niz[i]);
            }

            brojProba = 10000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_100K_elemenata_stepen_10

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100000 * 10, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_10.Dodavanje(niz[i]);
            }

            brojProba = 100000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1M_elemenata_stepen_10

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000000 * 10, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_10.Dodavanje(niz[i]);
            }

            brojProba = 1000000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_10.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            Console.WriteLine("**********************");

            #endregion

            #region Test_Bplus_33

            bplus_3 = new BplusStablo(33);

            Console.WriteLine("\t\t Stepen 33 \n\n");

            #region Test_100_elemenata_stepen_33

            Console.WriteLine("Test sa 100 čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100 * 33, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 100 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1K_elemenata_stepen_33

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000 * 33, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 1000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_10K_elemenata_stepen_33

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(10000 * 33, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 10000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_100K_elemenata_stepen_33

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100000 * 33, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 100000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1M_elemenata_stepen_33

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000000 * 33, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 1000000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            Console.WriteLine("**********************");

            #endregion

            #region Test_Bplus_101

           bplus_3 = new BplusStablo(101);

            Console.WriteLine("\t\t Stepen 101 \n\n");

            #region Test_100_elemenata_stepen_101

            Console.WriteLine("Test sa 100 čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100 * 101, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 100 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1K_elemenata_stepen_101

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000 * 101, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 1000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_10K_elemenata_stepen_101

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(10000 * 101, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 10000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_100K_elemenata_stepen_101

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100000 * 101, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 100000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1M_elemenata_stepen_101

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000000 * 101, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 1000000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            Console.WriteLine("**********************");

            #endregion

            #region Test_Bplus_333

            bplus_3 = new BplusStablo(333);

            Console.WriteLine("\t\t Stepen 333 \n\n");

            #region Test_100_elemenata_stepen_333

            Console.WriteLine("Test sa 100 čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100 * 333, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 100 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1K_elemenata_stepen_333

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000 * 333, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 1000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_10K_elemenata_stepen_333

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(10000 * 333, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 10000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_100K_elemenata_stepen_333

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100000 * 333, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 100000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1M_elemenata_stepen_333

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000000 * 333, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 1000000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            Console.WriteLine("**********************");

            #endregion

            #region Test_Bplus_1001

            bplus_3 = new BplusStablo(1001);

            Console.WriteLine("\t\t Stepen 1001 \n\n");

            #region Test_100_elemenata_stepen_1001

            Console.WriteLine("Test sa 100 čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100 * 1001, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 100 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1K_elemenata_stepen_1001

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000 * 1001, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 1000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_10K_elemenata_stepen_1001

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(10000 * 1001, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 10000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_100K_elemenata_stepen_1001

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(100000 * 1001, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 100000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            #region Test_1M_elemenata_stepen_1001

            Console.WriteLine("Test sa 1K čvorova");
            Console.WriteLine("---------------------------");

            sort.RandomNiz(1000000 * 1001, out niz, "");
            for (int i = 0; i < niz.Length; i++)
            {
                bplus_3.Dodavanje(niz[i]);
            }

            brojProba = 1000000 / 10;
            // brisanje:
            Console.WriteLine("Brisanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Brisanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // dodavanje:
            Console.WriteLine("Dodavanje");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Dodavanje(random.Next(0, 10000));
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga:
            Console.WriteLine("Pretraga");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.Pretraga(random.Next(0, 10000), out pom, out _);
                Console.WriteLine((i + 1) + ". test: " + prikaz + "| \t element: " + pom);
            }
            Console.WriteLine("/////////////////////////////");

            // pretraga intervala:
            Console.WriteLine("Pretraga intervala");
            Console.WriteLine("/////////////////////////////");
            for (int i = 0; i < brojProba; i++)
            {
                prikaz = bplus_3.PretragaIntervala(random.Next(0, 5000), random.Next(5001, 10000), out pom2);
                Console.WriteLine((i + 1) + ". test: " + prikaz);
            }
            Console.WriteLine("/////////////////////////////");

            Console.WriteLine("---------------------------");
            #endregion

            Console.WriteLine("**********************");

            #endregion

            Console.ReadLine();
        }
    }
}
