using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите предложение");
                string startString = Console.ReadLine();
                startString = startString.Replace(" ", "");
                char[] massivSlov = startString.ToCharArray();
                Array.Reverse(massivSlov);
                string lastString = new string(massivSlov);
                if (startString == lastString)
                {
                    Console.WriteLine("Строка является палиндромом");
                }
                else
                { 
                    Console.WriteLine("Не является палиндромом"); 
                }
            }
            Console.ReadKey();
        }
    }
}