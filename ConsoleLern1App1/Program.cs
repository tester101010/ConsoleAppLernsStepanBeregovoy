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
            /// таблица умножения 5 на 5 без массивов
            /// "this is second branch reserev"
            ///</summary>
            Console.WriteLine(" таблица умножения 5 на 5 без массивов");

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
            #region MyRegion
            /*
            m[0, 0] = 1 * 1; m[0, 1] = 1 * 2; m[0, 2] = 1 * 3; m[0, 3] = 1 * 4; m[0, 4] = 1 * 5;
            m[1, 0] = 2 * 1; m[1, 1] = 2 * 2; m[1, 2] = 2 * 3; m[1, 3] = 2 * 4; m[1, 4] = 2 * 5;
            m[2, 0] = 3 * 1; m[2, 1] = 3 * 2; m[2, 2] = 3 * 3; m[2, 3] = 3 * 4; m[2, 4] = 3 * 5;
            m[3, 0] = 4 * 1; m[3, 1] = 4 * 2; m[3, 2] = 4 * 3; m[3, 3] = 4 * 4; m[3, 4] = 4 * 5;
            m[4, 0] = 5 * 1; m[4, 1] = 5 * 2; m[4, 2] = 5 * 3; m[4, 3] = 5 * 4; m[4, 4] = 5 * 5;
            */
            #endregion
            for (int i = 0; i < amountN; i++)
            {
                #region MyRegion
                //    m[0, i] = 1 * (i + 1);
                //Console.WriteLine($"\tcol 1  col 2   col 3   col 4   col 5");
                #endregion
                Console.Write($"\t col { i + 1}");
            }
            Console.WriteLine();

            Console.Write("\t");

            for (int i = 0; i < amountN; i++)
            {
            Console.Write($"--------");
            }
            Console.WriteLine();
           // Console.WriteLine($"\t------------------------------------");
            for (int i = 0; i < amountN; i++)
            {
                #region MyRegion
                //    m[0, i] = 1 * (i + 1);
                //Console.WriteLine($"\tcol 1  col 2   col 3   col 4   col 5");
                #endregion
                Console.WriteLine($"\nline { i + 1}-\t  {m[i, 0]}\t  {m[i, 1]}\t  {m[i, 2]}\t  {m[i, 3]}\t  {m[i, 4]}");
            }
            #region MyRegion
            //Console.WriteLine($"line 1-\t  {m[0, 0]}\t  {m[0, 1]}\t  {m[0, 2]}\t  {m[0, 3]}\t  {m[0, 4]}");
            //Console.WriteLine($"line 2-\t  {m[1, 0]}\t  {m[1, 1]}\t  {m[1, 2]}\t  {m[1, 3]}\t  {m[1, 4]}");
            //Console.WriteLine($"line 3-\t  {m[2, 0]}\t  {m[2, 1]}\t  {m[2, 2]}\t  {m[2, 3]}\t  {m[2, 4]}");
            //Console.WriteLine($"line 4-\t  {m[3, 0]}\t  {m[3, 1]}\t  {m[3, 2]}\t  {m[3, 3]}\t  {m[3, 4]}");
            //Console.WriteLine($"line 5-\t  {m[4, 0]}\t  {m[4, 1]}\t  {m[4, 2]}\t  {m[4, 3]}\t  {m[4, 4]}");
            #endregion
            Console.WriteLine("\n this is second branch reserev");

            Console.ReadKey();
        }
    }
}
