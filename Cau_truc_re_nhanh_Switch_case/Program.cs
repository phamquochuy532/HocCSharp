using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_truc_re_nhanh_Switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch dang thieu 
            //// kiem tra tu trn xuong duoi

            //int h = 4;

            //switch (h)
            //{
            //    case 3:
            //        Console.WriteLine(" HuyDepTrai");
            //        break;

            //    case 4:
            //        Console.WriteLine(" HuyThongMinh");
            //        break ;
            //}

            #endregion

            #region Switch default

            //int k = 0;

            //switch (k)
            //{
            //    case 3:
            //        Console.WriteLine(" HuyDepTrai");
            //        break;

            //    case 4:
            //        Console.WriteLine(" HuyThongMinh");
            //        break;

            //    default: // neu tat ca cac case khong co thi no buoc phai chay vao " default ".
            //             // 1 Switch - case chi co 1 default.
            //             // default la cau lenh mac dinh

            //        Console.WriteLine(" Huy la nhat");
            //        break;
            //}

            #endregion

            #region bai tap

            int Year; // Bien chua nam can tinh
            string Can = "", Chi = ""; // Bien chua ket qua

            Console.Write(" Moi ban nhap nam can tinh: ");
            Year = Int32.Parse(Console.ReadLine()); // Nhap nam duong lich va ep kieu ve kieu so nguyen

            switch (Year % 10) // Tim can nhu thuat toan trinh bay
            {
                case 0: // Moi case nay tuong ung voi moi ket qua tra cuu trong bang tra cuu Can
                    Can = "Canh"; // Gia tri tuong ung voi moi case
                    break;

                case 1:
                    Can = "Tan";
                    break;

                case 2:
                    Can = "Nham";
                    break;

                case 3:
                    Can = "Quy";
                    break;

                case 4:
                    Can = "Giap";
                    break;

                case 5:
                    Can = "At";
                    break;

                case 6:
                    Can = "Binh";
                    break;

                case 7:
                    Can = "Dinh";
                    break;

                case 8:
                    Can = "Mau";
                    break;

                case 9:
                    Can = "Ky";
                    break;
            }

            switch (Year % 12) // Tim chi nhu thuat toan da trinh bay
            {
                case 0: // Moi case nay tuong ung voi moi ket qua tra cuu trong bang tra cuu Chi
                    Chi = "Than"; // Gia tri tuong ung voi moi case
                    break;

                case 1:
                    Chi = "Dau";
                    break;

                case 2:
                    Chi = "Tuat";
                    break;

                case 3:
                    Chi = "Hoi";
                    break;

                case 4:
                    Chi = "Ty";
                    break;

                case 5:
                    Chi = "Suu";
                    break;

                case 6:
                    Chi = "Dan";
                    break;

                case 7:
                    Chi = "Meo";
                    break;

                case 8:
                    Chi = "Thin";
                    break;

                case 9:
                    Chi = "Ti";
                    break;

                case 10:
                    Chi = "Ngo";
                    break;

                case 11:
                    Chi = "Mui";
                    break;
            }

            Console.WriteLine(" Nam {0} co nam am lich la: {1} {2}", Year, Can, Chi); // Noi Can voi Chi thanh nam a, lich

                    #endregion
                    Console.ReadKey(); 
        }
    }
}
