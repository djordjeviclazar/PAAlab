using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class BinarniHeap : IHeapFun
    {
        private int capacity, length;
        int[] elements;

        public int Capacity { get { return capacity; } }
        public int Length { get { return length; } }

        public BinarniHeap(int[] elements, int capacity)
        {
            this.length = elements.Length;
            this.capacity = capacity > this.length? capacity: this.length;
            this.elements = new int[capacity];
            
            for(int i = 0; i < length; i++)
            {
                this.elements[i] = elements[i];
            }

            // heapify:
            for (int i = ((length - 1) >> 1); i >= 0; i--)
            {
                DownHeap(ref this.elements, i, length - 1, false);
            }
        }

        public int Add(int newValue)
        {
            if (length >= capacity) { return -1; }

            elements[length++] = newValue;
            UpHeap(ref elements, length - 1, false);

            return 0;
        }

        public int DecreaseKey(int elementIndex, int newValue)
        {
            if (newValue >= ValueAt(elementIndex) || ValueAt(elementIndex) < 0) { return -1; }

            elements[elementIndex] = newValue;
            UpHeap(ref elements, elementIndex, false);

            return 0;
        }

        public int Delete(int elementIndex)
        {
            if (DecreaseKey(elementIndex, int.MinValue) < 0) { return -1; }
            if (ExtractMin() != int.MinValue) { return -1; }

            return 0;
        }

        public int ExtractMin()
        {
            if (length < 1) { return -1; }

            int minValue = elements[0];
            elements[0] = elements[--length];
            DownHeap(ref elements, 0, length - 1, false);

            return 0;
        }

        public int ValueAt(int index)
        {
            if (index >= length) { return -1; }

            return elements[index];
        }

        private void UpHeap(ref int[] heap, int ind, bool maxHeap)
        {
            if (ind > length - 1) { return; }

            while (ind > 0)
            {
                int k = ((ind + 1) >> 1) - 1;

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

        private void DownHeap(ref int[] heap, int ind, int lastElement, bool maxHeap)
        {
            while (ind < lastElement)
            {
                int k = (ind + 1) << 1;
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
                    return;
                }

                int c1 = heap[ind].CompareTo(heap[k - 1]);
                int c2 = heap[ind].CompareTo(heap[k]);
                if ((c1 > 0 && c2 > 0 && maxHeap) || (c1 < 0 && c2 < 0 && !maxHeap))
                {
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
            }
        }
    }
}
