using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polindrom
{
    internal class Stack
    {
        public int top;
        int size;
        public char[] values;
        public Stack(int size)
        {
            this.size = size;
            this.top = -1;
            values = new char[size];

        }

        public void push(string data)
        {
            if(DoluMu())
                Console.WriteLine("Stack dolu!");
            else
            {
                for(int i = 0; i < data.Length; i++)
                {
                    this.top++;
                    values[i] = data[i];
                }

            }
        }

        public void print()
        {
            if (BosMu())
                Console.WriteLine("Stack Boş!");
            else
            {
                int k = 0;
                for (int i = this.top; i > -1; i--)
                {
                    Console.WriteLine(this.values[i]);
                }
            }
        }

        public Boolean DoluMu()
        {
            return this.top == (this.size - 1);          
        }
        public Boolean BosMu()
        {
            return this.top == -1;
        }
    }
}
