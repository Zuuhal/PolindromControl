using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindrom
{
    internal class Queue
    {
        public int size;
        int front;
        int rear;
        public char[] Qvalues;

        public Queue(int size)
        {
            this.size = size;
            Qvalues = new char[size];
            front = rear = -1;
        }

        public void enQueue(string data)
        {
            if (DoluMu())
                Console.WriteLine("Kuyruk Dolu");
            else
            {
                for (int i = 0; i < data.Length; i++)
                {
                    rear++;
                    Qvalues[i] = data[i];
                }
            }
        }

        public void print()
        {
            if (BosMu())
                Console.WriteLine("Kuyruk Boş!");
            else
            {
                for (int i = front +1; i < this.size; i++)
                {
                    Console.WriteLine(Qvalues[i]);
                }
            }
        }
        public Boolean BosMu()
        {
            return this.rear == this.front;
        }
        public Boolean DoluMu()
        {
            return this.rear == (size - 1);
        }
    }
}
