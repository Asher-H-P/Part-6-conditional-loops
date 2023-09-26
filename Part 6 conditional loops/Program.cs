using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_conditional_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string answer = "";
            while (i <= 10)
            {
                Console.Write(i);
                i = i + 2;
            }
            Console.WriteLine();
            while (answer != "batman")
            {
                Console.WriteLine("What is Bruce Wayne's alter ego?");
                answer = Console.ReadLine().ToLower();
            }
            Console.WriteLine("CORRECT!");
        }
    }
}
