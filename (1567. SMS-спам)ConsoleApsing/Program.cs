using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int G = 0;
            int summa = 0;
            string a = "pokupaite gvozdi tolko v kompanii gvozdederov i tovarischi!";
            for (int i = 0; i < a.Length; i++)
            {

                string k = Convert.ToString(a[i]);

                if (k == "a" || k == "d" || k == "g" || k == "j" || k == "m" || k == "p" || k == "s" || k == "v" || k == "y" || k == "." || k == " ")
                //summa += summa + 1;

                {
                   summa += 1;
                }
                
                else if (k == "b" || k == "e" || k == "h" || k == "k" || k == "n" || k == "q" || k == "t" || k == "w" || k == "z" || k == ",")
                // summa += summa + 2;

                {
                    summa += 2;
                }

                else if (k == "c" || k == "f" || k == "i" || k == "l" || k == "o" || k == "r" || k == "u" || k == "x" || k == "!")
                //summa += summa + 3;

                {
                    summa += 3;
                }

                 G = summa;

            }

            Console.WriteLine(summa);
            Console.ReadKey();
            
        }
    }
}
