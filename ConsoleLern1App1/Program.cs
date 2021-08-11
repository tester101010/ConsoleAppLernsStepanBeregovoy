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
            /// таблица умножения с массивом и циклами v_1.1
            /// "this is second branch reserev"
            ///</summary>
            Console.WriteLine(" таблица умножения с массивом и циклами v_1.1");
            int amountN = 5;
            Console.Write("Введите целое(!) число размерности таблицы  ");
            string amountS = Console.ReadLine();
            amountN = Convert.ToInt32(amountS);
            Console.WriteLine($"Размерность таблицы: {amountN} на {amountN} ");

            int[,] m = new int[amountN, amountN];

            for (int i = 0; i < amountN; i++)
            {
                for (int j = 0; j < amountN; j++)
                {
                    m[i, j] = (i + 1) * (j + 1);
                }
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
                Console.Write($"\nLine { i + 1} -");
                for (int j = 0; j < amountN; j++)
                {
                    Console.Write($"  {m[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n this is second branch reserev");
            Console.ReadKey();
         }
    }
}
