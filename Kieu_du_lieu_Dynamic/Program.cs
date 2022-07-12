using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kieu_du_lieu_Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region dac diem cua kieu Dynamic

            ///*
            // * Khai bao bien StringValue kieu dynamic va khoi tao gia tri la mot chuoi kieu string
            // */

            //dynamic StringValue = "HuyDepTrai";

            ///*
            // * Chung ta biet rang kieu chuoi khong ho tro toan tu ++
            // * Nhung cau lenh StringValue++ van khong bao loi 
            // * la do o thoi diem hien tai trinh bien dich van chua xac dinh duoc kieu du lieu cho bien StringValur
            // * Khi chay chuong trinh thi luc nay C# moi phat hien bien StringValue 
            // * la kieu string va khong the thuc hien toan tu ++ luc do moi bao loi
            // */

            //StringValue++;

            //Console.ReadKey();
            #endregion

            #region Chuong trinh su dung Dynamic

            // Khai bao 2 bien Name va Class kieu string va khoi tao gia tri

            string Name = "Huy";
            string Class = "Thong Minh";

            /*
             * Thuc hien gan 1 kieu string cho bien kieu dynamic bang cach ep kieu ngam dinh (implicit)
             * Sau phep gan nay thi bien DynamicValue chua gia tri "Huy" 
             * nhung kieu du lieu cua no van chua duoc xac dinh
             * 
             */

            dynamic DynamicValue = Name;
            
            // Thuc hien cong chuoi va in ra man hinh
            Console.WriteLine(" Chang lang tu " + DynamicValue + " la mot nguoi " + Class );
            Console.ReadKey();

            #endregion
        }
    }
}
