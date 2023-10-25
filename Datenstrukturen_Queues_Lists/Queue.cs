using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenstrukturen_Queues_Lists
{




    public class Queue <T>: IQueue
    {

        private T[] data;

        public int Count => throw new NotImplementedException();
        private int head = 0;
        private int tail = 1;

        // Alternative

        //private LinkedList items = new LinkedList();


        public Queue(int queueLength) {
            if (queueLength < 2) {
                throw new Exception("Grösser als 1!!!");
            }
            data = new T[queueLength];

        }

        void Enqueue(T item)
        {
            if (data[tail] == null)
            {
                data[tail] = item;
            }
            else
            {
                Console.WriteLine("Es können keine Elemente mehr hinzugefügt werden!");
            }
            IncrementTail();
        }

        private void IncrementTail()
        {
            int oldTail = tail;
            tail++;
            if (tail == data.Length)
            {
                if (data[0] == null)
                {
                    tail = 0;
                }
                else
                {
                    tail = oldTail;
                }
            }
        }
        T Dequeue()
        {
            T item = data[head];
            data[head] = default(T);
            int oldHead = head;
            head++;
            if (head == tail)
            {
                head = oldHead;
            }
            else
            {
                IncrementTail(); 
            }

            return item;
        }

        public object Peek()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }









    public interface IQueue
    {

        void Enqueue(object item);

        void Dequeue();

        object Peek();

        void Clear();

        int Count { get; }

    }
}