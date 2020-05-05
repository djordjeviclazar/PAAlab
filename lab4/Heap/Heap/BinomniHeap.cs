using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class BinomniHeap : IHeapFun
    {
        private Node start;
        //private Node[] elements;
        private int capacity, length;

        public int Capacity { get { return capacity; } }
        public int Length { get { return length; } }

        public BinomniHeap()
        {
            length = 0;
            capacity = 100;
            //elements = new Node[capacity];
            start = null;
        }

        public BinomniHeap(int[] niz, int capacity)
        {
            length = 0;
            this.capacity = capacity > niz.Length ? capacity : niz.Length;
            start = null;
            //elements = new Node[this.capacity];
            for (int i = 0; i < niz.Length; i++)
            {
                Add(niz[i]);
            }
        }

        public int Add(int newValue)
        {
            // novi Heap
            BinomniHeap newElement = new BinomniHeap();
            newElement.start = new Node(newValue);
            if (this.Union(newElement) < 0) { return -1; }

            this.length++;
            return 0;
        }

        public int DecreaseKey(int elementIndex, int newValue)
        {
            Node node = Find(elementIndex);
            if (node == null) { return -1; }
            //if (newValue >= node.key) { return -1; }

            if (newValue == int.MinValue)
            {
                node.key = newValue;
            }
            else
            {
                // po uslovu zadatka domen [0,10000]
                node.key -= newValue;
                if (node.key < 0) { node.key = 0; }
            }

            Node current = node, next = node.parent;
            while (next != null && current.key < next.key)
            {
                int pom = current.key;
                current.key = next.key;
                next.key = pom;

                current = next;
                next = next.parent;
            }
            return 0;
        }

        public int Delete(int elementIndex)
        {
            this.DecreaseKey(elementIndex, int.MinValue);
            if (this.ExtractMin() == int.MinValue) { return 0; }

            return -1;
        }

        public int ExtractMin()
        {
            FindMin(out Node previous, out Node minimum);

            Node pom = minimum.next;
            int minValue = minimum.key;
            if (previous != null) { previous.right = minimum.right; }
            else { start = minimum.right; }

            Node i = pom, k = null;
            while (i != null)
            {
                i.parent = null;

                pom = i.right;
                i.right = k;
                k = i;
                i = pom;
            }
            BinomniHeap childList = new BinomniHeap();
            childList.start = k;
            this.Union(childList);

            this.length--;
            return minValue;
        }

        private Node Find(int elementIndex)
        {
            Node returnElement;
            int i = 0;

            if (start == null) { return null; }
            if (elementIndex > this.length - 1) { return null; }
            Node node = SearchNext(0, elementIndex, start, out _);
            return node;
        }

        private Node SearchNext(int currentIndex, int elementIndex, Node currentNode, out int endIndex)
        {
            if (currentNode == null) { endIndex = currentIndex; return null; }
            if (currentIndex == elementIndex) { endIndex = elementIndex; return currentNode; }

            currentIndex++;
            Node node;
            int ind = currentIndex - 1;
            if (currentNode.right != null)
            {
                node = SearchNext(currentIndex, elementIndex, currentNode.right, out ind);
                if (node != null) { endIndex = elementIndex; return node; }
            }

            int nextIndex = ind + 1;
            if (currentNode.next != null)
            {
                node = SearchNext(nextIndex, elementIndex, currentNode.next, out ind);
                if (node != null) { endIndex = elementIndex; return node; }
            }

            endIndex = ind;
            return null;
        }

        private void FindMin(out Node previous, out Node minimum)
        {
            previous = null;
            minimum = start;
            Node current = start, previousCurrent = null;

            while (current != null)
            {
                if (current.key < minimum.key)
                {
                    previous = previousCurrent;
                    minimum = current;
                }

                previousCurrent = current;
                current = current.right;
            }
        }

        public int Union(BinomniHeap newHeap)
        {
            if (this.Merge(newHeap) < 0) { return -1; }

            Node previous = null, current = this.start, next = current.right;
            while(next != null)
            {
                if ((current.degree != next.degree) || (next.right != null && next.right.degree == current.degree))
                {
                    previous = current;
                    current = next;

                    next = next.right;
                    continue;
                }
                else
                {
                    if (current.key <= next.key)
                    {
                        current.right = next.right;
                        Link(next, current);

                        next = current.right;
                        continue;
                    }
                    else
                    {
                        if (previous == null) { start = next; }
                        else { previous.right = next; }
                        Link(current, next);
                        current = next;

                        next = next.right;
                        continue;
                    }
                }
                // GREŠKA (next.right je promenjen ako je slučaj 3): 
                //next = next.right;
            }
            return 0;
        }

        private int Merge(BinomniHeap newHeap)
        {
            //if (capacity < (this.length + newHeap.length)) { return -1; }
            if (newHeap == null || newHeap.start == null) { return -1; }
            if (start == null) { start = newHeap.start; return 0; }

            Node thisCurrent = this.start, newCurrent = newHeap.start, prev = null;
            while (thisCurrent != null)
            {
                if (newCurrent == null) { break; }
                // ovo se nikad ne izvršava:
                //if (thisCurrent == null) { thisCurrent = newCurrent; break; }

                if (thisCurrent.degree <= newCurrent.degree) 
                {
                    prev = thisCurrent;
                    thisCurrent = thisCurrent.right;
                    continue;
                }

                if (prev == null)
                {
                    prev = newCurrent;
                    newCurrent = newCurrent.right;
                    prev.right = thisCurrent;
                    this.start = prev;
                    continue;
                }

                // prev, thisCurrent, newCurrent != null
                Node pom = newCurrent.right;
                newCurrent.right = prev.right;
                prev.right = newCurrent;
                prev = newCurrent;
                newCurrent = pom;
                continue;
            }
            if (newCurrent != null) 
            {
                prev.right = newCurrent; 
            }
            return 0;
        }

        private void Link(Node first, Node second)
        {
            first.parent = second;
            first.right = second.next;
            second.next = first;
            second.degree++;
        }

        class Node
        {
            internal Node parent, next, right;
            internal int key, degree, index;

            internal Node(int key)
            {
                this.key = key;
                parent = null;
                next = null;
                right = null;
                degree = 0;
            }
        }
    }
}
