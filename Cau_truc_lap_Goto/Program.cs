using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_truc_lap_Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region vi du 0

            //// go to: thong bao cho trinh bien dich biet
            //// se di den cai nhanx ("HuyDepTrai") ngay sau do de tiep tuc thuc hien code
            //goto HuyDepTrai;

            //Console.WriteLine(" Qua ghe gom"); // bo qua 

            //HuyDepTrai: // no se bo qua tat ca cac dong lenh de chay den "HuyDepTai"
            //Console.WriteLine(" Nhat the gian");
            //Console.ReadKey();

            #endregion

            #region vi du 1

            //int a = 3;
            //switch (a)
            //{                                   
            //    case 1:                             // label case 1
            //        Console.WriteLine("Case 1");    
            //        break;
            //    case 2:                             // label case 2
            //        Console.WriteLine("Case 2");    
            //        goto case 1;                    // dich chuyen toi lable case 1
            //        break;                          // doan cod enay thua vi se khong bao h thuc thi,
            //                                        // co the bo
            //    case 3:
            //        Console.WriteLine("Case 3");
            //        break ;
            //}
            //Console.ReadKey();

            #endregion

            #region vi du 2

            //int a = 1; // co the thay a = 2 (no se nhayr ngay toi cau lenh 61)
            //           // thay vi di tu cau 58 xuong

            //if (a == 2)
            //{
            //    // Dich chuyen toi vi tri lable a_Is_2
            //    goto a_Is_2;
            //}

            //Console.WriteLine(" Huy");

            //a_Is_2:
            //Console.WriteLine(" Ngan");
            //Console.ReadKey();

            #endregion

            #region vi du 3

            //    int a = 2; // co the thay a = 2 (no se nhayr ngay toi cau lenh 61)
            //               // thay vi di tu cau 58 xuong
            //    Ifinity_Loop:
            //    if (a == 2)
            //    {
            //        // Dich chuyen toi vi tri lable a_Is_2
            //        goto a_Is_2;
            //    }

            //    Console.WriteLine(" Huy");

            //a_Is_2:
            //    Console.WriteLine(" Ngan");
            //    goto Ifinity_Loop;
            //    Console.ReadKey();

            #endregion

            #region vi du 4

        //    string h = " Huy Dep Trai";

        //    int a = 0;
        //    int b = 1;

        //Begin_Loop:

        //    Console.WriteLine(b++ +h);
        //    a++;

        //    if (a < 10)
        //    goto Begin_Loop;
            
            
        //    Console.WriteLine(" stop");
            
        //    Console.ReadKey();

            #endregion

            // khong nen dung goto: vi no se pha vo cau truc cua mot chuong trinh
        }
    }
}
