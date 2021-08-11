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
            /// таблица умножения 5 на 5  c массиваом
            /// "this is first master branch"
            ///</summary>
            Console.WriteLine(" таблица умножения 5 на 5 c массиваом");

            #region без массива
            /*
            int X1_1, x1_2, x1_3, x1_4, x1_5;
            int X2_1, x2_2, x2_3, x2_4, x2_5;
            int X3_1, x3_2, x3_3, x3_4, x3_5;
            int X4_1, x4_2, x4_3, x4_4, x4_5;
            int X5_1, x5_2, x5_3, x5_4, x5_5;           

            X1_1 = 1 * 1; x1_2 = 1 * 2; x1_3 = 1 * 3; x1_4 = 1 * 4; x1_5 = 1 * 5;
            X2_1 = 2 * 1; x2_2 = 2 * 2; x2_3 = 2 * 3; x2_4 = 2 * 4; x2_5 = 2 * 5;
            X3_1 = 3 * 1; x3_2 = 3 * 2; x3_3 = 3 * 3; x3_4 = 3 * 4; x3_5 = 3 * 5;
            X4_1 = 4 * 1; x4_2 = 4 * 2; x4_3 = 4 * 3; x4_4 = 4 * 4; x4_5 = 4 * 5;
            X5_1 = 5 * 1; x5_2 = 5 * 2; x5_3 = 5 * 3; x5_4 = 5 * 4; x5_5 = 5 * 5;
            */
            #endregion

            int[,] m = new int[5, 5];

            m[0, 0] = 1 * 1; m[0, 1] = 1 * 2; m[0, 2] = 1 * 3; m[0, 3] = 1 * 4; m[0, 4] = 1 * 5;
            m[1, 0] = 2 * 1; m[1, 1] = 2 * 2; m[1, 2] = 2 * 3; m[1, 3] = 2 * 4; m[1, 4] = 2 * 5;
            m[2, 0] = 3 * 1; m[2, 1] = 3 * 2; m[2, 2] = 3 * 3; m[2, 3] = 3 * 4; m[2, 4] = 3 * 5;
            m[3, 0] = 4 * 1; m[3, 1] = 4 * 2; m[3, 2] = 4 * 3; m[3, 3] = 4 * 4; m[3, 4] = 4 * 5;
            m[4, 0] = 5 * 1; m[4, 1] = 5 * 2; m[4, 2] = 5 * 3; m[4, 3] = 5 * 4; m[4, 4] = 5 * 5;

            Console.WriteLine($"\tcol 1  col 2   col 3   col 4   col 5");
            Console.WriteLine($"\t------------------------------------");

            Console.WriteLine($"line 1-\t {m[0, 0]}\t{m[0, 1]}\t{m[0, 2]}\t{m[0, 3]}\t{m[0, 4]}");
            Console.WriteLine($"line 2-\t {m[1, 0]}\t{m[1, 1]}\t{m[1, 2]}\t{m[1, 3]}\t{m[1, 4]}");
            Console.WriteLine($"line 3-\t {m[2, 0]}\t{m[2, 1]}\t{m[2, 2]}\t{m[2, 3]}\t{m[2, 4]}");
            Console.WriteLine($"line 4-\t {m[3, 0]}\t{m[3, 1]}\t{m[3, 2]}\t{m[3, 3]}\t{m[3, 4]}");
            Console.WriteLine($"line 5-\t {m[4, 0]}\t{m[4, 1]}\t{m[4, 2]}\t{m[4, 3]}\t{m[4, 4]}");

            Console.WriteLine("this is first master branch");

            Console.ReadKey();
        }
    }
}
