﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condition_new
{
    class Program
    {
        static void Main(string[] args)
        {
            /*condiction dicleration*/
            Console.WriteLine("choose your fast integer number a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose your second integer number b ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a is bigger then b ", a);
            }
            else
            {
                Console.WriteLine("b is a bigger than a ", b);
            }


            Console.ReadKey();
        }
    }
}
