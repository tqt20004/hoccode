﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace tinhdientichhinhvuong
{

    internal class Program
    {

        static void Main(string[] args)
        {
            int i = 10;
            float f = 20.5f;
            double d = 20.5;
            Boolean b = true;
            char c = 'a';
            String s = "CodeGym";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Gia' trị của biến i là " + i);
            Console.WriteLine("Gia' trị của biến f là " + f);
            Console.WriteLine("Giá trị của biến d là " + d);
            Console.WriteLine("Giá trị của biến b là " + b);
            Console.WriteLine("Giá trị của biến c là " + c);
            Console.WriteLine("Giá trị của biến i là " + s);
        }
    }
}
