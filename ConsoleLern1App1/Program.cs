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
            /// "this is first master branch"
            /// </summary>
            Console.WriteLine(" таблица умножения 5 на 5 без массивов");

            int X1_1, x1_2, x1_3, x1_4, x1_5;
            int X2_1, x2_2, x2_3, x2_4, x2_5;
            int X3_1, x3_2, x3_3, x3_4, x3_5;
            int X4_1, x4_2, x4_3, x4_4, x4_5;
            int X5_1, x5_2, x5_3, x5_4, x5_5;

            X1_1 = 1*1; x1_2 = 1*2; x1_3 = 1*3; x1_4 = 1*4; x1_5 = 1*5;
            X2_1 = 2*1; x2_2 = 2*2; x2_3 = 2*3; x2_4 = 2*4; x2_5 = 2*5;
            X3_1 = 3*1; x3_2 = 3*2; x3_3 = 3*3; x3_4 = 3*4; x3_5 = 3*5;
            X4_1 = 4*1; x4_2 = 4*2; x4_3 = 4*3; x4_4 = 4*4; x4_5 = 4*5;
            X5_1 = 5*1; x5_2 = 5*2; x5_3 = 5*3; x5_4 = 5*4; x5_5 = 5*5;

            Console.WriteLine($"\tcol 1  col 2   col 3   col 4   col 5");
            Console.WriteLine($"\t------------------------------------");

            Console.WriteLine($"line 1-\t {X1_1}\t{x1_2}\t{x1_3}\t{x1_4}\t{x1_5}");
            Console.WriteLine($"line 2-\t {X2_1}\t{x2_2}\t{x2_3}\t{x2_4}\t{x2_5}");
            Console.WriteLine($"line 3-\t {X3_1}\t{x3_2}\t{x3_3}\t{x3_4}\t{x3_5}");
            Console.WriteLine($"line 4-\t {X4_1}\t{x4_2}\t{x4_3}\t{x4_4}\t{x4_5}");
            Console.WriteLine($"line 5-\t {X5_1}\t{x5_2}\t{x5_3}\t{x5_4}\t{x5_5}");

            Console.WriteLine("this is first master branch");

            Console.ReadKey();
        }
    }
}
