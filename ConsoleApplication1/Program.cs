using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 5, b = 1;
            swap(ref a, ref b);
            Console.WriteLine("a={0}, b={1}", a, b);                   
            Console.ReadLine();
        }
        /// <summary>
        /// Обмен значений переменных.
        /// </summary>
        /// <param name="a">Первая переменная.</param>
        /// <param name="b">Вторая переменная</param>
        private static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
