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

            sort.RandomNiz(100, out int[] proba, "");

            String vreme = sort.MergeSort(proba, true, out int[] sortiran);
            bool p = sort.Sortiran(sortiran, true);
            Console.WriteLine("Merge sort:\r\n" + vreme + "\r\n" + "Sortiran: " + p);

            vreme = sort.CountingSort(proba, true, out sortiran);
            p = sort.Sortiran(sortiran, true);
            Console.WriteLine("Counting sort:\r\n" + vreme + "\r\n" + "Sortiran: " + p);

            int[] proba1 = new int[proba.Length];
            for(int i = 0; i < proba.Length; i++) { proba1[i] = proba[i]; }
            vreme = sort.InsertionSort(proba1, true, out sortiran);
            p = sort.Sortiran(sortiran, true);
            Console.WriteLine("Insertion sort:\r\n" + vreme + "\r\n" + "Sortiran: " + p);

            for (int i = 0; i < proba.Length; i++) { proba1[i] = proba[i]; }
            vreme = sort.HeapSort(proba1, true, out sortiran);
            p = sort.Sortiran(sortiran, true);
            Console.WriteLine("Heap sort:\r\n" + vreme + "\r\n" + "Sortiran: " + p);

            for (int i = 0; i < proba.Length; i++) { proba1[i] = proba[i]; }
            vreme = sort.SelectionSort(proba1, true, out sortiran);
            p = sort.Sortiran(sortiran, true);
            Console.WriteLine("Selection sort:\r\n" + vreme + "\r\n" + "Sortiran: " + p);

            Console.Read();
        }
    }
}
