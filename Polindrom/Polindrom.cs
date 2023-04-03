using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindrom
{
    internal class Polindrom
    {
       public int polidrom(Queue kuyruk, Stack yigin)
       {
            int k = 0;
            for (int i = yigin.top; i > -1; i--)
            {
                if (kuyruk.Qvalues[k] != yigin.values[i])
                {
                    Console.WriteLine("Polindrom değil!");
                    return 0;
                }
                k++;
            }
            Console.WriteLine("Polindrom");
            return 0;         
        }


    }
}
