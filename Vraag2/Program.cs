using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int engelsPunt;
            int programPunt;
            int infoPunt;
            int sum;
            int gemid;
            bool work= true;

            

            do
            {
                

                Console.Write("What's your name: ");
                name = Console.ReadLine();

                Console.Write("Geef je punten voor Engels: ");
                engelsPunt = int.Parse(Console.ReadLine());
                
                Console.Write("geef je punten voor informatica ");
                infoPunt = int.Parse(Console.ReadLine());
               
                Console.Write("geef je punten voor programatie ");
                programPunt = int.Parse(Console.ReadLine());

                Console.WriteLine("geen andere leerling toevoegen druk op n");
                string input = Console.ReadLine();
                if (input == "n")
                {
                    work = false;
                }









            } while (work);

           


            sum = engelsPunt + programPunt + infoPunt;
            Console.WriteLine($"dit is de som: {sum}");
            gemid = engelsPunt + programPunt + infoPunt;
            Console.WriteLine($"dit is het gemiddelde: {gemid}");

        }
    }
}
