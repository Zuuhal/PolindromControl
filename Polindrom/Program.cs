using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cvp;
            do
            {
                Console.WriteLine("Bir kelime giriniz: ");
                string A = Console.ReadLine();

                Stack stack = new Stack(A.Length);
                stack.push(A);
                Console.WriteLine("STACK YAPISI: ");
                stack.print();
                Console.WriteLine();

                Queue kuyruk = new Queue(A.Length);
                kuyruk.enQueue(A);
                Console.WriteLine("QUEUE YAPISI: ");
                kuyruk.print();
                Console.WriteLine();

                Polindrom pol = new Polindrom();
                pol.polidrom(kuyruk, stack);
                Console.WriteLine();
                Console.WriteLine("Devam etmek iter misiniz? (e/h): ");
                cvp = Convert.ToChar(Console.ReadLine());
            } while (cvp == 'e' || cvp == 'E');
        }
    }
}
