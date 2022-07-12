using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tu_khoa_ref_va_out
{
    internal class Program
    {
        #region ref

        static void Main(string[] args)
        {
            int value = 5;
            Console.WriteLine(" Value before increase: {0}", value);

            IncreaseValue( value);

            Console.WriteLine(" Value after increase: {0}", value);

            Console.ReadLine();
        }

        static void IncreaseValue( int value)
        {
            value++;
        }

        #endregion

        #region out

        //static void Main(string[] args)
        //{
        //    int value = 5; // out: khong ban tam thang truyen vao nay bawng bao nhieu
        //    Console.WriteLine(" Value before increase: {0}", value);

        //    IncreaseValue(out value);

        //    Console.WriteLine(" Value after increase: {0}", value);

        //    Console.ReadLine();
        //}

        //static void IncreaseValue(out int value)
        //{
        //    value = 0;
        //    value++;
        //}

        #endregion
    }
}
