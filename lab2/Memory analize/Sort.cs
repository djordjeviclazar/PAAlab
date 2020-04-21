using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sortiranje
{
    public class Sort
    {
        static long maximalMemory;
        public bool startCountingMemory{ get; set; }

        public String SelectionSort(int[] niz, bool rastući, out int[] sortiranNiz)
        {
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            sortiranNiz = new int[niz.Length];
            for (int i = 0; i < niz.Length; i++) { sortiranNiz[i] = niz[i]; }

            /*long currentMemory;
            startMemory = GC.GetTotalMemory(true);
            if (startCountingMemory != true) { maximalMemory = startMemory; }*/

            for (int i = 0; i < sortiranNiz.Length - 1; i++)
            {
                int element = i;
                for (int k = i + 1; k < sortiranNiz.Length; k++)
                {
                    if (rastući && sortiranNiz[k].CompareTo(sortiranNiz[element]) < 0) { element = k; }
                    if (!rastući && sortiranNiz[k].CompareTo(sortiranNiz[element]) > 0) { element = k; }

                    /*currentMemory = GC.GetTotalMemory(true);
                    if (currentMemory > maximalMemory) { maximalMemory = currentMemory; }*/
                }

                int p = sortiranNiz[element];
                sortiranNiz[element] = sortiranNiz[i];
                sortiranNiz[i] = p;

                /*currentMemory = GC.GetTotalMemory(true);
                if (currentMemory > maximalMemory) { maximalMemory = currentMemory; }*/
            }


            //maxMemory = maximalMemory;
            stopwatch.Stop();
            return stopwatch.Elapsed + "";
        }

        public String HeapSort(int[] niz, bool rastući, out int[] sortiranNiz)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            sortiranNiz = new int[niz.Length];
            for (int i = 0; i < niz.Length; i++) { sortiranNiz[i] = niz[i]; }

            /*long currentMemory;
            startMemory = GC.GetTotalMemory(true);
            if (startCountingMemory != true) { maximalMemory = startMemory; }*/

            // pravljenje heap-a
            for (int i = (sortiranNiz.Length - 1) / 2; i >= 0; i--)
            {
                DownHeap(ref sortiranNiz, i, sortiranNiz.Length - 1, rastući);
            }

            for(int i = (sortiranNiz.Length - 1); i > 0; i--)
            {
                // brisanje korena:
                int p = sortiranNiz[i];
                sortiranNiz[i] = sortiranNiz[0];
                sortiranNiz[0] = p;
                DownHeap(ref sortiranNiz, 0, i - 1, rastući);
            }

            //maxMemory = maximalMemory;
            stopwatch.Stop();
            return stopwatch.Elapsed + "";
        }

        /*void Heapify(ref int[] niz,int ind, bool maxHeap)
        {
            int c1 = (ind + 1) * 2, c2 = (ind + 1) * 2 + 1, max = ind;

            int c = niz[max].CompareTo(niz[c1]);
            if (c1 < niz.Length && ((c < 0 && maxHeap) || (c > 0 && !maxHeap))) { max = c1; }

            c = niz[max].CompareTo(niz[c2]);
            if (c2 < niz.Length && ((c < 0 && maxHeap) || (c > 0 && !maxHeap))) { max = c2; }

            if (max != ind)
            {
                int p = niz[max];
                niz[max] = niz[ind];
                niz[ind] = p;
                Heapify(ref niz, max, maxHeap);
            }
        }*/

        void UpHeap(ref int[] heap, int ind, bool maxHeap)
        {
            while (ind > 0)
            {
                int k = ind / 2 - 1;

                int c = heap[ind].CompareTo(heap[k]);
                if ((c > 0 && !maxHeap) || (c < 0 && maxHeap))
                {
                    return;
                }

                int p = heap[ind];
                heap[ind] = heap[k];
                heap[k] = p;
                ind = k;
            }
        }

        void DownHeap(ref int[] heap, int ind, int lastElement, bool maxHeap)
        {
            //long currentMemory;

            while (ind < lastElement)
            {
                int k = (ind + 1) * 2;
                if (k - 1 > lastElement) { return; }
                if (k - 1 == lastElement)
                {
                    int comp = heap[ind].CompareTo(heap[k - 1]);
                    if ((comp < 0 && maxHeap) || (comp > 0 && !maxHeap))
                    {
                        int pom = heap[ind];
                        heap[ind] = heap[k - 1];
                        heap[k - 1] = pom;
                    }

                    /*currentMemory = GC.GetTotalMemory(true);
                    if (currentMemory > maximalMemory) { maximalMemory = currentMemory; }
                    return;*/
                }

                int c1 = heap[ind].CompareTo(heap[k - 1]);
                int c2 = heap[ind].CompareTo(heap[k]);
                if ((c1 > 0 && c2 > 0 && maxHeap) || (c1 < 0 && c2 < 0 && !maxHeap))
                {
                    /*currentMemory = GC.GetTotalMemory(true);
                    if (currentMemory > maximalMemory) { maximalMemory = currentMemory; }*/
                    return;
                }

                int p = heap[ind];
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

                /*currentMemory = GC.GetTotalMemory(true);
                if (currentMemory > maximalMemory) { maximalMemory = currentMemory; }*/
            }
        }

        public String CountingSort(int[] niz, bool rastući, out int[] sortiranNiz)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] brojač = new int[10001];
            int[] sortNiz = new int[niz.Length];

            /*long currentMemory;
            startMemory = GC.GetTotalMemory(true);
            if (startCountingMemory != true) { maximalMemory = startMemory; }*/

            for (int i = 0; i < niz.Length; i++)
            {
                brojač[niz[i]] = brojač[niz[i]] + 1; 
            }

            for(int i = 1; i < brojač.Length; i++)
            {
                brojač[i] += brojač[i - 1];
            }

            for(int i = niz.Length - 1; i >= 0; i--)
            {
                /*sortNiz[brojač[niz[i]]] = niz[i];
                brojač[niz[i]] = brojač[niz[i]] - 1;*/
                int a = niz[i];
                int b = brojač[a];
                sortNiz[b - 1] = a;
                brojač[a] = b - 1;

                /*currentMemory = GC.GetTotalMemory(true);
                if (currentMemory > maximalMemory) { maximalMemory = currentMemory; }*/
            }

            sortiranNiz = sortNiz;

            //maxMemory = maximalMemory;
            stopwatch.Stop();
            return stopwatch.Elapsed + "";
        }

        public String MergeSort(int[] niz, bool rastući, out int[] sortiranNiz)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            sortiranNiz = new int[niz.Length];

            if (niz.Length <= 1) 
            { 
                // InsertionSort(niz, rastući, out sortiranNiz, out startMemory, out _);
                stopwatch.Stop();

                sortiranNiz = niz;
                //startMemory = 0;
                //maxMemory = maximalMemory;
                return stopwatch.Elapsed + "";
            }

            int[] prvaPolovina = new int[niz.Length / 2];
            int[] drugaPolovina = new int[niz.Length - prvaPolovina.Length];

            /*long currentMemory;
            startMemory = GC.GetTotalMemory(true);
            if (startCountingMemory != true) { maximalMemory = startMemory; }*/

            int i;
            for(i = 0; i < prvaPolovina.Length; i++)
            {
                prvaPolovina[i] = niz[i];
            }
            for(int k = 0; k < drugaPolovina.Length; k++)
            {
                drugaPolovina[k] = niz[i++];
            }

            MergeSort(prvaPolovina, rastući, out int[] prvi);
            MergeSort(drugaPolovina, rastući, out int[] drugi);
            Merge(ref sortiranNiz, prvi, drugi, rastući);

            //maxMemory = maximalMemory;
            stopwatch.Stop();
            return stopwatch.Elapsed + "";
        }

        void Merge(ref int[] niz, int[] prvaPolovina, int[] drugaPolovina, bool rastući)
        {
            int i = 0, k = 0, el = 0;

            //long currentMemory;

            while (i < prvaPolovina.Length && k < drugaPolovina.Length)
            {
                int c = prvaPolovina[i].CompareTo(drugaPolovina[k]);
                if ((c < 0 && rastući) || (c > 0 && !rastući)) { niz[el] = prvaPolovina[i++]; }
                else { niz[el] = drugaPolovina[k++]; }

                el++;

                /*currentMemory = GC.GetTotalMemory(true);
                if (currentMemory > maximalMemory) { maximalMemory = currentMemory; }*/
            }

            for(int ind = el; ind < niz.Length; ind++)
            {
                if(i < prvaPolovina.Length) { niz[ind] = prvaPolovina[i++]; }
                else { niz[ind] = drugaPolovina[k++]; }
            }
        }

        public String InsertionSort(int[] niz, bool rastući, out int[] sortiranNiz)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            sortiranNiz = new int[niz.Length];
            for (int i = 0; i < niz.Length; i++) { sortiranNiz[i] = niz[i]; }

            //long currentMemory;
            /*startMemory = GC.GetTotalMemory(true);
            if (startCountingMemory != true) { maximalMemory = startMemory; }*/

            for (int i = 1; i < sortiranNiz.Length; i++)
            {
                int p = sortiranNiz[i], k = i - 1;
                while ((rastući && p.CompareTo(sortiranNiz[k]) < 0) || (!rastući && p.CompareTo(sortiranNiz[k]) > 0))
                {
                    sortiranNiz[i--] = niz[k--];
                    if (k < 0) { k = 0; break; }

                    /*currentMemory = GC.GetTotalMemory(true);
                    if (currentMemory > maximalMemory) { maximalMemory = currentMemory; }*/
                }
                sortiranNiz[i] = p;
            }


            //maxMemory = maximalMemory;
            stopwatch.Stop();
            return stopwatch.Elapsed + "";
        }

        public bool Sortiran(int [] niz, bool rastući)
        {
            int i = 1;
            while (i < niz.Length) 
            {
                int c = niz[i].CompareTo(niz[i - 1]);
                if ((c >= 0 && rastući) || (c <= 0 && !rastući))
                {
                    i++;
                    continue;
                }
                return false;
            }
            return true;
        }

        public void RandomNiz(int brojElemenata, out int[] niz, String opcije)
        {
            Random random = new Random();
            niz = new int[brojElemenata];

            for (int i = 0; i < brojElemenata; i++) { niz[i] = random.Next(0, 10000); }

            if (opcije.Equals("Rastući")) { MergeSort(niz, true, out niz, out _, out _); }
            if (opcije.Equals("Opadajući")) { MergeSort(niz, false, out niz, out _, out _); }
        }
    }
}
