using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kieu_du_lieu_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region vi du 1

            //object obj = "HuyDepTrai";

            ///*
            // * boxing: chuyen tu kieu du lieu gia tri sang kieu du lieu tham chieu
            // */

            //int value = 109;

            //object objectValue = value; // se copy cai gia tri "value" tha vao cai "objectValue"

            //int newValue = (int)objectValue;
            //Console.WriteLine(newValue);

            //Console.ReadKey();

            #endregion

            #region "var"

            //var varInt; // loi vi "var" phai khoi tao luon ngay khi khai bao

            //var varInt = null; // loi vi "var" khong the null

            //var varInt;     // loi giong thu nhat
            //varInt = 109;

            // "var" chi la mot tu khoa khai bao bien chu "khong phai" la kieu du lieu
            // ung dung: thuong dung trong duyet mang bang (foreach), truy van link kiu

            var varString = "HuyDepTrai";

            string content = "RatThongMinh";

            Console.WriteLine(varString);
            Console.WriteLine(content);
            

            Console.ReadLine();
            #endregion
        }
    }
}
