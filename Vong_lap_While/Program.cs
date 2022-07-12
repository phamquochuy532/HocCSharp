using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vong_lap_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region vi du 1

            //int countLoop = 0;
            //int countLoopTime = 0;
            //int valueNum = 10;
            //int loopTime = 5;

            //// Ve tu tren xuong loopTime lan
            //while (countLoopTime < loopTime)
            //{
            //    // Reset bien countLoop ve 0 deviet lai tu dau
            //    countLoop = 0;

            //    // Ve tu trai qua valueNum lan
            //    while (countLoop < valueNum)
            //    {
            //        // In  gia tri cua countLooptrong 8 vi tri
            //        Console.Write("{0,8}", countLoop);

            //        // Tang gia tri cua bien countLoop len mot don vi
            //        countLoop++;
            //    }

            //    // Moi khi hoan thnah mot vong lap nho thi lai xuong dong chuan bi vong lap tiep theo
            //    Console.WriteLine();


            //    // Tang gia tri countLoopTime len mot don vi
            //    countLoopTime++;
            //}

            #endregion

            #region vi du 2

            //int countLoop = 0;
            //int countLoopTime = 0;
            //int valueNum = 10;
            //int loopTime = 5;
            //int minRandomValue = 0;
            //int maxRandomValue = 100;

            //Random rand = new Random();
            //// Ve tu tren xuong loopTime lan
            //while (countLoopTime < loopTime)
            //{
            //    // Reset bien countLoop ve 0 deviet lai tu dau
            //    countLoop = 0;

            //    // Ve tu trai qua valueNum lan
            //    while (countLoop < valueNum)
            //    {

            //        // Gia tri sinh ngau nhien trong khoang [ minRandomValue ... maxRandomValue -1 ]
            //        int showValue = rand.Next(minRandomValue, maxRandomValue);

            //        // In  gia tri cua countLooptrong 8 vi tri
            //        Console.Write("{0,8}", showValue);

            //        // Tang gia tri cua bien countLoop len mot don vi
            //        countLoop++;
            //    }

            //    // Moi khi hoan thnah mot vong lap nho thi lai xuong dong chuan bi vong lap tiep theo
            //    Console.WriteLine();


            //    // Tang gia tri countLoopTime len mot don vi
            //    countLoopTime++;
            //}

            #endregion

            #region vi du 3

            int Vertical = 10;
            int Horizontal = 20;
            char drawChar = '*';
            char insideChar = '.';
            int countLoopVertical = 0;
            int countLoopHorizontal = 0;

            Console.Write("\n");
            // Vẽ từ trên xuống
            while (countLoopVertical < Vertical)
            {

                // khởi tạo lại giá trị countLoopHorizontal = 0 mỗi lần lặp mới
                countLoopHorizontal = 0;

                // Vẽ từ trái sang
                while (countLoopHorizontal < Horizontal)
                {

                    /*
                     * Nếu đang ở tọa độ là cạnh trên hoặc dưới i % (N - 1) == 0
                     * hoặc đang ở cạnh trái hoặc phải (j % (M - 1) == 0)
                     * mà không nằm ở cạnh trên hoặc dưới (i % (N - 1) != 0)
                     * ((i % (N - 1) != 0) && (j % (M - 1) == 0))
                     * thì vẽ ra ký tự của hình chữ nhật
                     * ngược lại vẽ ra ký tự không thuộc hình chữ nhật
                    */

                    if (countLoopVertical % (Vertical - 1) == 0 || ((countLoopVertical % (Vertical - 1) != 0) && (countLoopHorizontal % (Horizontal - 1) == 0)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // mau
                        Console.Write(drawChar);    // lúc này là ký tự *
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow; // mau
                        Console.Write(insideChar);  // lúc này là ký tự rỗng '.'
                    }


                    // tăng giá trị của countLoopHorizontal lên 1 đơn vị
                    countLoopHorizontal++;
                }

                // mỗi lần vẽ xong một hàng thì xuống dòng
                Console.WriteLine();


                // tăng giá trị của countLoopVertical lên 1 đơn vị
                countLoopVertical++;
            }


            #endregion

            Console.ReadLine();
        }
    }
}
