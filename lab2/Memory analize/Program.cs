using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortiranje
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort sort = new Sort();

            /*sort.RandomNiz(100, out int[] proba, "");

            String vreme = sort.MergeSort(proba, true, out int[] sortiran);
            bool p = sort.Sortiran(sortiran, true);
            Console.WriteLine("Merge sort:\r\n" + vreme + "\r\n" + "Sortiran: " + p);

            vreme = sort.CountingSort(proba, true, out sortiran);
            p = sort.Sortiran(sortiran, true);
            Console.WriteLine("Counting sort:\r\n" + vreme + "\r\n" + "Sortiran: " + p);

            //int[] proba1 = new int[proba.Length];
            //for(int i = 0; i < proba.Length; i++) { proba1[i] = proba[i]; }
            vreme = sort.InsertionSort(proba, true, out sortiran);
            p = sort.Sortiran(sortiran, true);
            Console.WriteLine("Insertion sort:\r\n" + vreme + "\r\n" + "Sortiran: " + p);

            //for (int i = 0; i < proba.Length; i++) { proba1[i] = proba[i]; }
            vreme = sort.HeapSort(proba, true, out sortiran);
            p = sort.Sortiran(sortiran, true);
            Console.WriteLine("Heap sort:\r\n" + vreme + "\r\n" + "Sortiran: " + p);

            //for (int i = 0; i < proba.Length; i++) { proba1[i] = proba[i]
            vreme = sort.SelectionSort(proba, true, out sortiran);
            p = sort.Sortiran(sortiran, true);
            Console.WriteLine("Selection sort:\r\n" + vreme + "\r\n" + "Sortiran: " + p);

            Console.Read();*/
            //long memory, startMemory, maxMemory;
            int brojElemenata = 10;
            for (int i = 1; i <= 7; i++)
            {
                brojElemenata *= 10;
                for (int k = 1; k <= 1; k++)
                {
                    sort.RandomNiz(brojElemenata, out int[] proba, "");
                    bool p;
                    String vreme;

                    Console.WriteLine("\tTest " + i + "." + k + "\r\nBROJ ELEMENATA = " + brojElemenata + "\r\n");

                    //memory = GC.GetTotalMemory(true);
                    if (brojElemenata <= 10_000_000)
                    {
                        int[] sortiran1;
                        vreme = sort.MergeSort(proba, true, out sortiran1);
                        p = sort.Sortiran(sortiran1, true);
                        Console.WriteLine("MERGE sort:\r\n");
                        Console.WriteLine("Vreme izvršenja =" + vreme + "\r\n");

                        /*Console.WriteLine("Zauzeće memorije:" + "\r\n");
                        Console.WriteLine("Stanje pre procesа = " + memory + " B" + "\t");
                        Console.WriteLine("Stanje na početku procesa = " + startMemory + " B" + "\t");
                        Console.WriteLine("Maksimalno zauzeće memorije = " + maxMemory + " B" + "\r\n");
                        Console.WriteLine("Maksimalno zauzeće memorije u okviru procesa = " + (maxMemory - memory) + " B" + "\r\n");*/
                        Console.WriteLine("Sortiran: " + p + "\r\n\r\n");
                    }

                    //memory = GC.GetTotalMemory(true);
                    vreme = sort.CountingSort(proba, true, out int[] sortiran);
                    p = sort.Sortiran(sortiran, true);
                    Console.WriteLine("COUNTING sort:\r\n");
                    Console.WriteLine("Vreme izvršenja =" + vreme + "\r\n");
                    //Console.WriteLine("Zauzeće memorije = " + "\r\n");
                    //Console.WriteLine("Stanje pre procesa = " + memory + " B" + "\t");
                    //Console.WriteLine("Stanje na početku procesa = " + startMemory + " B" + "\t");
                    //Console.WriteLine("Maksimalno zauzeće memorije = " + maxMemory + " B" + "\r\n");
                    //Console.WriteLine("Maksimalno zauzeće memorije u okviru procesa = " + (maxMemory - memory) + " B" + "\r\n");
                    Console.WriteLine("Sortiran: " + p + "\r\n\r\n");

                    /*if (brojElemenata <= 10_000)
                    {
                        //memory = GC.GetTotalMemory(true);
                        vreme = sort.InsertionSort(proba, true, out sortiran);
                        p = sort.Sortiran(sortiran, true);
                        Console.WriteLine("INSERTION sort:\r\n");
                        Console.WriteLine("Vreme izvršenja =" + vreme + "\r\n");
                        Console.WriteLine("Zauzeće memorije = " + "\r\n");
                        Console.WriteLine("Stanje pre procesa = " + memory + " B" + "\t");
                        Console.WriteLine("Stanje na početku procesa = " + startMemory + " B" + "\t");
                        Console.WriteLine("Maksimalno zauzeće memorije = " + maxMemory + " B" + "\r\n");
                        Console.WriteLine("Maksimalno zauzeće memorije u okviru procesa = " + (maxMemory - memory) + " B" + "\r\n");
                        Console.WriteLine("Sortiran: " + p + "\r\n\r\n");
                    }*/

                    //memory = GC.GetTotalMemory(true);
                    vreme = sort.HeapSort(proba, true, out sortiran);
                    p = sort.Sortiran(sortiran, true);
                    Console.WriteLine("HEAP sort:\r\n");
                    Console.WriteLine("Vreme izvršenja =" + vreme + "\r\n");
                    /*Console.WriteLine("Zauzeće memorije = " + "\r\n");
                    Console.WriteLine("Stanje pre procesa = " + memory + " B" + "\t");
                    Console.WriteLine("Stanje na početku procesa = " + startMemory + " B" + "\t");
                    Console.WriteLine("Maksimalno zauzeće memorije = " + maxMemory + " B" + "\r\n");
                    Console.WriteLine("Maksimalno zauzeće memorije u okviru procesa = " + (maxMemory - memory) + " B" + "\r\n");*/
                    Console.WriteLine("Sortiran: " + p + "\r\n\r\n");

                    if (brojElemenata <= 100_000)
                    {
                        //memory = GC.GetTotalMemory(true);
                        vreme = sort.SelectionSort(proba, true, out sortiran);
                        p = sort.Sortiran(sortiran, true);
                        Console.WriteLine("SELECTION sort:\r\n");
                        Console.WriteLine("Vreme izvršenja =" + vreme + "\r\n");
                        /*Console.WriteLine("Zauzeće memorije = " + "\r\n");
                        Console.WriteLine("Stanje pre procesa = " + memory + " B" + "\t");
                        Console.WriteLine("Stanje na početku procesa = " + startMemory + " B" + "\t");
                        Console.WriteLine("Maksimalno zauzeće memorije = " + maxMemory + " B" + "\r\n");
                        Console.WriteLine("Maksimalno zauzeće memorije u okviru procesa = " + (maxMemory - memory) + " B" + "\r\n");*/
                        Console.WriteLine("Sortiran: " + p + "\r\n\r\n");
                    }

                    Console.WriteLine("----------------------------------------------------- \r\n\r\n");
                }
            }
        }
    }
}
