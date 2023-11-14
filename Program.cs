using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Case_Console
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int Count_Space = 0;
            int Count_Character = 0;

            string Text = Console.ReadLine();
            bool fHasSpace = Text.Contains(" ");
                foreach (char item in Text)
                {
                    if (item == ' ')
                    {
                        Count_Space++;
                    }
                }
                foreach (char item in Text)
                {
                    Count_Character++;
                }

                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                Console.WriteLine(myTI.ToTitleCase(Text));
                Console.WriteLine("Spaces : {0}", Count_Space);
                Console.WriteLine("Character : {0}", Count_Character);
            
            Console.ReadKey();
        }
    }
}
