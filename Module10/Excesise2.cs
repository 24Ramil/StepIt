using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPriorityQueue
{
    internal class PriorityQueue<T>
    {
        private List<T> heap;
        private IComparer<T> comparer;

        public int Count => heap.Count;
        public PriorityQueue() : this(Comparer<T>.Default) { }

        public PriorityQueue(IComparer<T> comparer)
        {
            this.heap = new List<T>();
            this.comparer = comparer;
        }

        public void Enqueue(T item)
        {
            heap.Add(item);
            int currentIndex = Count - 1;

            while (currentIndex > 0)
            {
                int parentIndex = (currentIndex - 1) / 2;
                if (comparer.Compare(heap[currentIndex], heap[parentIndex]) >= 0)
                    break;

                Swap(currentIndex, parentIndex);
                currentIndex = parentIndex;
            }
        }

        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            T root = heap[0];
            heap[0] = heap[Count - 1];
            heap.RemoveAt(Count - 1);

            int currentIndex = 0;
            while (true)
            {
                int leftChildIndex = 2 * currentIndex + 1;
                int rightChildIndex = 2 * currentIndex + 2;
                int smallestChildIndex = currentIndex;

                if (leftChildIndex < Count && comparer.Compare(heap[leftChildIndex], heap[smallestChildIndex]) < 0)
                    smallestChildIndex = leftChildIndex;

                if (rightChildIndex < Count && comparer.Compare(heap[rightChildIndex], heap[smallestChildIndex]) < 0)
                    smallestChildIndex = rightChildIndex;

                if (smallestChildIndex == currentIndex)
                    break;

                Swap(currentIndex, smallestChildIndex);
                currentIndex = smallestChildIndex;
            }

            return root;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            return heap[0];
        }

        private void Swap(int index1, int index2)
        {
            T temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }
    }
}
