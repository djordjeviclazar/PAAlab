using Sortiranje;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();

            long vreme, ukupno, avg;
            int brojElemenata;
            int[] niz;
            bool provera;

            #region BinomniHeapPrviTest
            /*
            test.RandomNiz(1000, out int[] niz, "");
            BinomniHeap bin1000 = new BinomniHeap(niz, 1500);

            int num = 1000 / 10;
            bool validanTest = true;
            //10% extract:
            int lastMin = -1;
            int pom;
            for (int i = 0; i < num; i++)
            {
                pom = bin1000.ExtractMin();
                if (pom < lastMin) { validanTest = false; }
                lastMin = pom;
            }

            //10% decreaseKey
            for (int i = 0; i < num; i++)
            {
                bin1000.DecreaseKey(random.Next(0, 999), random.Next(1, 10000));
            }

            //10% delete
            for (int i = 0; i < num; i++)
            {
                bin1000.Delete(random.Next(0, 999 - num));
            }

            //10% add
            for (int i = 0; i < num; i++)
            {
                bin1000.Add(random.Next(0, 10000));
            }

            bool validanTest2 = true;
            int[] provera = new int[bin1000.Length];
            for (int i = 0; i < provera.Length; i++)
            {
                if (i == 899)
                {
                    //
                }
                provera[i] = bin1000.ExtractMin();
            }
            validanTest2 = test.Sortiran(provera, true);

            Console.WriteLine("Prva provera: " + validanTest);
            Console.WriteLine("Druga provera: " + validanTest2);
            Console.ReadLine();
            */
            #endregion

            #region BinomniHeap

            BinomniHeap binomniHeap;

            Console.Write("\t\t BINOMNI HEAP \r\n\r\n");

            #region BinomniHeap-10-el

            brojElemenata = 10;
            Console.WriteLine("Broj elemenata:" + brojElemenata + "\r\n");
            sort.RandomNiz(brojElemenata, out niz, "");

            stopwatch.Start();
            binomniHeap = new BinomniHeap(niz, brojElemenata);
            stopwatch.Stop();
            Console.WriteLine("Inicijalizacija strukture: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.ExtractMin();

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("ExtractMin:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.DecreaseKey(random.Next(0, brojElemenata - 1), random.Next(1, 5000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("DecreaseKey:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.Delete(random.Next(0, brojElemenata - 1));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Delete:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.Add(random.Next(1, 10000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Add:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            Console.WriteLine("--------------------------");

            #endregion

            #region BinomniHeap-100-el

            brojElemenata = 100;
            Console.WriteLine("Broj elemenata:" + brojElemenata + "\r\n");
            sort.RandomNiz(brojElemenata, out niz, "");

            stopwatch.Start();
            binomniHeap = new BinomniHeap(niz, brojElemenata);
            stopwatch.Stop();
            Console.WriteLine("Inicijalizacija strukture: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.ExtractMin();

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("ExtractMin:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.DecreaseKey(random.Next(0, brojElemenata - 1), random.Next(1, 5000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("DecreaseKey:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.Delete(random.Next(0, brojElemenata - 1));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Delete:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.Add(random.Next(1, 10000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Add:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            Console.WriteLine("--------------------------");

            #endregion

            #region BinomniHeap-1K-el

            brojElemenata = 1000;
            Console.WriteLine("Broj elemenata:" + brojElemenata + "\r\n");
            sort.RandomNiz(brojElemenata, out niz, "");

            stopwatch.Start();
            binomniHeap = new BinomniHeap(niz, brojElemenata);
            stopwatch.Stop();
            Console.WriteLine("Inicijalizacija strukture: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.ExtractMin();

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("ExtractMin:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.DecreaseKey(random.Next(0, brojElemenata - 1), random.Next(1, 5000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("DecreaseKey:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.Delete(random.Next(0, brojElemenata - 1));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Delete:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.Add(random.Next(1, 10000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Add:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            Console.WriteLine("--------------------------");

            #endregion

            #region BinomniHeap-10K-el

            brojElemenata = 10000;
            Console.WriteLine("Broj elemenata:" + brojElemenata + "\r\n");
            sort.RandomNiz(brojElemenata, out niz, "");

            stopwatch.Start();
            binomniHeap = new BinomniHeap(niz, brojElemenata);
            stopwatch.Stop();
            Console.WriteLine("Inicijalizacija strukture: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.ExtractMin();

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("ExtractMin:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.DecreaseKey(random.Next(0, brojElemenata - 1), random.Next(1, 5000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("DecreaseKey:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.Delete(random.Next(0, brojElemenata - 1));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Delete:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.Add(random.Next(1, 10000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Add:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            Console.WriteLine("--------------------------");

            #endregion

            #region BinomniHeap-100K-el

            brojElemenata = 100000;
            Console.WriteLine("Broj elemenata:" + brojElemenata + "\r\n");
            sort.RandomNiz(brojElemenata, out niz, "");

            stopwatch.Start();
            binomniHeap = new BinomniHeap(niz, brojElemenata);
            stopwatch.Stop();
            Console.WriteLine("Inicijalizacija strukture: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.ExtractMin();

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("ExtractMin:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.DecreaseKey(random.Next(0, brojElemenata - 1), random.Next(1, 5000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("DecreaseKey:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.Delete(random.Next(0, brojElemenata - 1));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Delete:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binomniHeap.Add(random.Next(1, 10000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Add:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            Console.WriteLine("--------------------------");

            #endregion

            Console.WriteLine("**********************************");

            #endregion

            #region BinarniHeap

            BinarniHeap binarniHeap;

            Console.Write("\t\t BINARNI HEAP \r\n\r\n");

            #region BinarniHeap-10-el

            brojElemenata = 10;
            Console.WriteLine("Broj elemenata:" + brojElemenata + "\r\n");
            sort.RandomNiz(brojElemenata, out niz, "");

            stopwatch.Start();
            binarniHeap = new BinarniHeap(niz, brojElemenata);
            stopwatch.Stop();
            Console.WriteLine("Inicijalizacija strukture: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.ExtractMin();

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("ExtractMin:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.DecreaseKey(random.Next(0, brojElemenata - 1), random.Next(1, 5000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("DecreaseKey:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.Delete(random.Next(0, brojElemenata - 1));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Delete:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.Add(random.Next(1, 10000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Add:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            Console.WriteLine("--------------------------");

            #endregion

            #region BinarniHeap-100-el

            brojElemenata = 100;
            Console.WriteLine("Broj elemenata:" + brojElemenata + "\r\n");
            sort.RandomNiz(brojElemenata, out niz, "");

            stopwatch.Start();
            binarniHeap = new BinarniHeap(niz, brojElemenata);
            stopwatch.Stop();
            Console.WriteLine("Inicijalizacija strukture: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.ExtractMin();

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("ExtractMin:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.DecreaseKey(random.Next(0, brojElemenata - 1), random.Next(1, 5000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("DecreaseKey:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.Delete(random.Next(0, brojElemenata - 1));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Delete:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.Add(random.Next(1, 10000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Add:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            Console.WriteLine("--------------------------");

            #endregion

            #region BinarniHeap-1K-el

            brojElemenata = 1000;
            Console.WriteLine("Broj elemenata:" + brojElemenata + "\r\n");
            sort.RandomNiz(brojElemenata, out niz, "");

            stopwatch.Start();
            binarniHeap = new BinarniHeap(niz, brojElemenata);
            stopwatch.Stop();
            Console.WriteLine("Inicijalizacija strukture: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.ExtractMin();

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("ExtractMin:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.DecreaseKey(random.Next(0, brojElemenata - 1), random.Next(1, 5000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("DecreaseKey:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.Delete(random.Next(0, brojElemenata - 1));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Delete:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.Add(random.Next(1, 10000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Add:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            Console.WriteLine("--------------------------");

            #endregion

            #region BinarniHeap-10K-el

            brojElemenata = 10000;
            Console.WriteLine("Broj elemenata:" + brojElemenata + "\r\n");
            sort.RandomNiz(brojElemenata, out niz, "");

            stopwatch.Start();
            binarniHeap = new BinarniHeap(niz, brojElemenata);
            stopwatch.Stop();
            Console.WriteLine("Inicijalizacija strukture: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.ExtractMin();

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("ExtractMin:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.DecreaseKey(random.Next(0, brojElemenata - 1), random.Next(1, 5000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("DecreaseKey:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.Delete(random.Next(0, brojElemenata - 1));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Delete:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.Add(random.Next(1, 10000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Add:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            Console.WriteLine("--------------------------");

            #endregion

            #region BinarniHeap-100K-el

            brojElemenata = 100000;
            Console.WriteLine("Broj elemenata:" + brojElemenata + "\r\n");
            sort.RandomNiz(brojElemenata, out niz, "");

            stopwatch.Start();
            binarniHeap = new BinarniHeap(niz, brojElemenata);
            stopwatch.Stop();
            Console.WriteLine("Inicijalizacija strukture: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.ExtractMin();

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("ExtractMin:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.DecreaseKey(random.Next(0, brojElemenata - 1), random.Next(1, 5000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("DecreaseKey:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.Delete(random.Next(0, brojElemenata - 1));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Delete:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            ukupno = 0;
            for (int i = 0; i < brojElemenata / 10; i++)
            {
                stopwatch.Start();

                binarniHeap.Add(random.Next(1, 10000));

                stopwatch.Stop();
                ukupno += stopwatch.ElapsedMilliseconds;
                stopwatch.Reset();
            }
            avg = ukupno / (brojElemenata / 10);
            Console.WriteLine("Add:\r\nProsečno vreme: " + avg.ToString() + "\t Ukupno vreme: " + ukupno.ToString());

            Console.WriteLine("--------------------------");

            #endregion

            Console.WriteLine("**********************************");

            #endregion

            #region Provera

            Console.WriteLine("\t\t TEST \r\n");

            provera = true;
            int[] testBinomni = new int[binomniHeap.Length];
            int[] testBinarni = new int[binarniHeap.Length];
            
            {
                for (int i = 0; i < testBinomni.Length; i++)
                {
                    testBinomni[i] = binomniHeap.ExtractMin();
                }
                for (int i = 0; i < testBinarni.Length; i++)
                {
                    testBinarni[i] = binarniHeap.ExtractMin();
                }
                provera = sort.Sortiran(testBinomni, true);
                Console.WriteLine("Binomni heap: " + provera);
                provera = sort.Sortiran(testBinarni, true);
                Console.WriteLine("Binarni heap: " + provera);
            }
            #endregion

            Console.ReadLine();
        }
    }
}
