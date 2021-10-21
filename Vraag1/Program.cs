using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1;
            int numb2;
            int numb3;
            int i = 0;



            Console.WriteLine("give me a number");
            numb1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me a number");
            numb2 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me a number");
            numb3 = int.Parse(Console.ReadLine());

          
            while (i <= 1)
            {
                

                if (numb1 > numb2)
                {
                    if (numb1 > numb3)
                    {
                        Console.WriteLine(" number 1 is biggest " + numb1);
                    }

                    
                }
                else if(numb2> numb3)
                {
                    Console.WriteLine("number 2 is the biggest " + numb2);
                }
                else
                {
                    Console.WriteLine("number 3 is the biggest "+ numb3);
                }
                i++;
                
            }
                        
            
                
            
        }
    }
    }

