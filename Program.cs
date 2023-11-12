using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Case_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Text = Console.ReadLine();
            bool fHasSpace = Text.Contains(" ");
            if (fHasSpace == true)
            {
                int Count_Space = 0;
                foreach (char item in Text)
                {
                    if (item == ' ')
                    {  
                        Count_Space++; 
                    }
                }
                
                Console.WriteLine("Spaces : {0}",Count_Space);
            }
            else
            {
                Console.WriteLine("This Can't Be Converted");
            }

            Console.ReadKey();
        }
    }
}
