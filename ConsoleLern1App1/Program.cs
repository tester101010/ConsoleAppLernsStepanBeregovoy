using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLern1App1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            /// таблица умножения с массивом и циклами v_1
            /// "this is second branch reserev"
            ///</summary>
            Console.WriteLine(" таблица умножения с массивом и циклами v_1");

            int amountN = 5;

            int[,] m = new int[amountN, amountN];

            for (int i = 0; i < amountN; i++)
            {
                m[0, i] = 1 * (i + 1);
            }
            for (int i = 0; i < amountN; i++)
            {
                m[1, i] = 2 * (i + 1);
            }
            for (int i = 0; i < amountN; i++)
            {
                m[2, i] = 3 * (i + 1);
            }
            for (int i = 0; i < amountN; i++)
            {
                m[3, i] = 4 * (i + 1);
            }
            for (int i = 0; i < amountN; i++)
            {
                m[4, i] = 5 * (i + 1);
            }

            for (int i = 0; i < amountN; i++)
            {
                Console.Write($"\t col { i + 1}");
            }
            Console.WriteLine();

            Console.Write("\t");

            for (int i = 0; i < amountN; i++)
            {
            Console.Write($"--------");
            }
            Console.WriteLine();

            for (int i = 0; i < amountN; i++)
            {
                Console.WriteLine($"\nline { i + 1}-\t  {m[i, 0]}\t  {m[i, 1]}\t  {m[i, 2]}\t  {m[i, 3]}\t  {m[i, 4]}");
            }

            Console.WriteLine("\n this is second branch reserev");

            Console.ReadKey();
        }
    }
}
