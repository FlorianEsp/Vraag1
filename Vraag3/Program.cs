using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;



            for ( number = 1; number <= 20; number++)
            {
           
                
                if ((number % 2) == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
