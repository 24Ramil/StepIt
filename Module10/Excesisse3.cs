using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYCircularQueue
{
    internal class CircularQueue<T>
    {
        private T[] buffer;
        private int capacity;
        private int front;
        private int rear;
        private int count;

        public int Count => count;

        public CircularQueue(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be a positive integer.");

            this.capacity = capacity;
            this.buffer = new T[capacity];
            this.front = 0;
            this.rear = -1;
            this.count = 0;
        }

        public void Enqueue(T item)
        {
            if (count == capacity)
                throw new InvalidOperationException("Queue is full.");

            rear = (rear + 1) % capacity;
            buffer[rear] = item;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("Queue is empty.");

            T item = buffer[front];
            buffer[front] = default(T);
            front = (front + 1) % capacity;
            count--;
            return item;
        }

        public T Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("Queue is empty.");

            return buffer[front];
        }

    }
}
