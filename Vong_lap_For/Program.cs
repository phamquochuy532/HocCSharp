using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vong_lap_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region vi du 1

            //for (/* Khoi tao */; /* Dieu kien lap */; /* Buoc lap */)
            //{
            //    /* Khoi lenh duoc lap */
            //}

            //int b = 1;
            //for (int i = 0;i < 10; i++)
            //{
            //    Console.WriteLine(b++ +" Huy Dep Trai");
            //}

            //Console.ReadLine();

            #endregion

            #region vi du 2

            //Console.OutputEncoding = Encoding.UTF8;

            //int i = 0;
            //int j = 0;

            //for (; i < 10; i++, j += 3, Console.WriteLine(" Nhieu hon de") )
            //{
            //    Console.WriteLine(" {0} | {1}", i, j);
            //}

            //Console.ReadLine();

            #endregion

            #region vi du 3

            int N = 10;
            int M = 20;
            char drawChar = '@';
            char insiteChar = '#';

            // ve tu tren xuong 
            for (int i = 0; i < N; i++)
            {
                // ve tu trai sang
                for (int j = 0; j < M; j++)
                {
                    /*
                     * Neu dang o toa do la canh tren duoi hoac duoi i % (N - 1) == 0
                     * hoac dang o canh trai hoac phai (j % (M -1) == 0)
                     * Ma khong nam o canh tren hoac duoi (i % (N - 1) != 0)
                     * (i % (N - 1) != 0) && (j % (M -1) == 0)
                     * thi ve ra ki tu hinh chu nhat
                     * Nguoc lai thi ve ra ki tu khong thuoc hinh chu nhat
                     */

                    if (i % (N - 1) == 0 || ((i % (N - 1) != 0) && (j % (M - 1) == 0)))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(drawChar); // Luc nay la ki tu "*"
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(insiteChar); // Luc nay la ki tu rong " "
                    }
                }
                // Moi lan ve xong mot hang la xuong dong
                Console.WriteLine();
            }
            Console.ReadKey();

            #endregion

        }
    }
}
