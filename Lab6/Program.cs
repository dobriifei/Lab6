using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            int rezultString = 0;
            foreach (string s in stringArray)
                if (s.Length > rezultString)
                {
                    rezultString = s.Length;

                }
            Console.WriteLine(rezultString);
            Console.ReadKey();
        }
    }

}

