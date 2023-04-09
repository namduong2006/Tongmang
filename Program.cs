using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tongmang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[] numbers = new int[5];
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
