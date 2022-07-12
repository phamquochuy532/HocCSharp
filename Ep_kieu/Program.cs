using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ep_kieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region chuyen doi ngam dinh

            //int k = 10;
            //long l = k; // chuyen doi ngam dinh vi kieu long co mien gia tri lon hon kieu int nen co the chuyen
            //float f = 10.9f;
            //double d = f; // tuong tu vi kieu double co mien gia tri lon hon float 

            #endregion

            #region chuyen doi tuong minh

            //int i = 300; // 300 co ma nhi phan la 100101100

            //byte b = (byte)i; // do kieu byte co gioi han den gia tri 255 thoi nen khong the chua so 300 duoc
            //                  // ma kieu byte co kich thuoc la 1 byte = 8 bit.
            //                  // Nhu vay ta can cat ma nhi phan cua 300 ve con 8 bit la duoc.
            //                  // Ma nhi phan 300 la 100101100 cat tu trai qua 1 bit ta duoc 00101100 ( du 8 bit) tuong duong voi 44.
            //                  // Cuoi cung bien b mang gia tri la 44

            //Console.WriteLine(" i = " + i);
            //Console.WriteLine(" b = " + b);

            //double d = 2 / 3; // ket qua ra la 0 vi 2 va 3 deu la so nguyen nen thuc hien 2 chi lay phan du
            //double k = (double)2 / 3; // ep kieu so 2 tu kieu nguyen sang kieu so thuc
            //double t = 1.0 * 2 / 3; // thuc hien nhan 1.0 voi 2 nham muc dich de bien so 2 (nguyen)

            //Console.WriteLine(" d = {0}\n k = {1}\n t = {2}\n", d, k, t);

            //Console.ReadKey();
            #endregion

            #region Parse()

            //string s = "10";
            //int k = int.Parse(s); // chuyen chuoi s sang kieu int và luu gia tri vao bien k - ket qua k = 10
            //double e = double.Parse("10.9"); // chuyen gia tri hang bang 10.9 sang kieu intva luu vao bien e

            #endregion

            #region TryParse()

            //int Result; // bien chua gia tri ket qua khi ep kieu thanh cong
            //bool isSuccess; // bien kiem tra ep kieu co thanh cong hay khong
            //string Data1 = "10", Data2 = "Huy"; // du lieu can ep kieu  

            //isSuccess = int.TryParse(Data1, out Result); // thu ep kieu Data1 ve int neu thanh cong thi Réult....
            //Console.WriteLine(isSuccess == true ? "Success !" : "Failed !"); // su dung toan tu 3 ngoi de in ra man hinh....
            //Console.WriteLine(" Result = " + Result); // in gia tri Result ra man hinh

            //isSuccess = int.TryParse(Data2, out Result); // tuong tu nhu tren vơi Data2
            //Console.WriteLine(isSuccess == true ? "Success !" : "Failed !"); 
            //Console.WriteLine(" Result = " + Result);

            //Console.ReadKey();

            #endregion

            #region Convert



            #endregion
        }
    }
}

/*
 * Chuyen doi ngam dinh
 * Chuyen doi tuong minh
 * Su dung phuong thuc, lop ho tro san => Parse(), TryParse(); Convert  
 * Nguoi dung tu dinh nghia kieu chuyen doi
 */
