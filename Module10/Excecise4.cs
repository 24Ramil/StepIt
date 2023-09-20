using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYList
{
    class MyList<T1>
    {
        private Node? head;
        private Node? tail;
        private int size;

        class Node
        {
            public T1 Value;
            public Node? next;
            public Node() { }
            public Node(T1 value)
            {
                Value = value;
            }

        }
        public T1 GetHeadValue()
        {
            return this.head.Value;
        }
        public T1 GetNextHeadValue()
        {
            return this.head.next.Value;
        }

        public void Swap(T1 value1, T1 value2)
        {
            Node? prev1 = null, prev2 = null;
            Node? current = head;

            while (current != null)
            {
                if (current.Value.Equals(value1))
                    break;
                prev1 = current;
                current = current.next;
            }

            current = head;

            while (current != null)
            {
                if (current.Value.Equals(value2))
                    break;
                prev2 = current;
                current = current.next;
            }

            if (prev1 != null && prev2 != null)
            {
                Node temp = prev1.next;
                prev1.next = prev2.next;
                prev2.next = temp;

                if (prev1 == tail)
                    tail = prev2.next;
                else if (prev2 == tail)
                    tail = prev1.next;
            }

        }

        public void Add(T1 value)
        {
            Node? node = new(value);
            if (this.head == null)
            {
                this.head = node;
                this.size++;
                return;
            }
            Node? current = this.head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = node;
            this.tail = node;
            this.size++;
        }
        public void AddStart(T1 value)
        {
            Node? node = new Node(value);
            if (this.head == null)
            {
                this.head = node;
                return;
            }
            else
            {
                Node? current = head;
                node.next = current;
                this.head = node;
            }
            this.size++;
        }
        public void Remove(T1 value)
        {
            if (this.head != null && this.head.Value.Equals(value))
            {
                this.head = this.head.next;
                this.size--;
                return;
            }

            Node? current = this.head;
            while (current != null && current.next != null)
            {
                if (current.next.Value.Equals(value))
                {
                    current.next = current.next.next;
                    this.size--;
                    return;
                }
                current = current.next;
            }
            Console.WriteLine("This value not exisist");
        }
        public void Pop()
        {
            if (this.head != null)
            {
                this.head = this.head.next;
                this.size--;
                return;
            }
            throw new Exception("Firat add ");
        }

        public void Show()
        {
            Node? current = this.head;
            for (int i = 0; i < this.size; i++)
            {
                Console.WriteLine(current.Value);
                current = current.next;
            }
        }
        public int Size()
        {
            return this.size;
        }

    }
}
