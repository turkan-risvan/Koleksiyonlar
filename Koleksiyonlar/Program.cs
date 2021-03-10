using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Türkan", "Sevde", "Kübra", "Birsen", "Delal" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);

            //isimler = new string[6];
            //isimler[5] = "Fatma";
            //Console.WriteLine(isimler[5]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "Türkan", "Sevde", "Kübra", "Birsen", "Delal" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);

            isimler2.Add("Ayşe");
            Console.WriteLine(isimler2[5]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
