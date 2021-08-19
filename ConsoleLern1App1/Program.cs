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
            MultypleTable();

            Console.ReadKey();
        }

        private static void MultypleTable()
        {
            ///<summary>
            /// таблица умножения с массивом и вложенными циклами v_2
            /// "this is master branch"
            ///</summary>
            Console.WriteLine(" таблица умножения с массивом и вложенными циклами v_2");

            int amountN = 5;

            int[,] m;

            InitAndCalculateTable(out amountN, out m);

            Console.Write("\t      ");
            for (int i = 0; i < amountN; i++)
            {
                Console.Write($" col_{ i + 1}  ");
            }
            Console.WriteLine();
            Console.Write("\t    ");

            for (int i = 0; i < amountN; i++)
            {
                Console.Write($"--------");
            }
            Console.WriteLine();

            TableLineHeaderRender(amountN, m);

            Console.WriteLine("\n this is second branch reserev");
        }

        private static void InitAndCalculateTable(out int amountN, out int[,] m)
        {
            Console.Write("Введите целое(!) число размерности таблицы  ");
            string amountS = Console.ReadLine();
            amountN = Convert.ToInt32(amountS);
            Console.WriteLine($"Размерность таблицы: {amountN} на {amountN} ");

            m = new int[amountN, amountN];
            for (int i = 0; i < amountN; i++)
            {
                for (int j = 0; j < amountN; j++)
                {
                    m[i, j] = (i + 1) * (j + 1);
                }
            }
        }

        private static void TableLineHeaderRender(int amountN, int[,] m)
        {
            for (int i = 0; i < amountN; i++)
            {
                Console.Write($"\n Line { i + 1}-");
                Console.Write("      ");
                for (int j = 0; j < amountN; j++)
                {
                    Console.Write($" {m[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n this is master branch");
            Console.ReadKey();
    }
}
