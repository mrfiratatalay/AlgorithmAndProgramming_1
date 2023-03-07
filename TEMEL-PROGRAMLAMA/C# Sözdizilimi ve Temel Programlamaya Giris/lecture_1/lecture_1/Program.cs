using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 13;
            // Herhangi bir degisken tanimlarkene tanimlayacagim degiskenin tipiyle kendisinin uyusmasi gerekir.
            //Yani; int myNumber = 13.5;  DIYEMEM.. Cunku 13.5 degerim int tipinde degil double tipinde.
            //Kisacasi atama operatorumun sol tarafindaki degerimle sag tarafindaki degerimin tipinin ORTUSMESI GEREKIYOR..
            double myNumber2 = 13.5;

            Console.WriteLine(myNumber.GetType());
            Console.WriteLine(myNumber2.GetType());

            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////////////////////////
            //Eger yapicagim islemin sonucunda cikti olarak alacagim degerin tipini tahmin edemiyorsam yani 
            //bilemiyorsam, O zaman degiskenlerimin tipini "var" ile tanimlarim.

            //ORNEGIN--1;
            var x = 8;
            var y = 9;
            var z = x + y;

            Console.WriteLine(z);
            Console.WriteLine(z.GetType());
            Console.ReadKey();

            //ORNEGIN--2;
            var k = "8";
            var l = "9";
            var m = k + l;

            Console.WriteLine(m);
            Console.WriteLine(m.GetType());
            Console.ReadKey();


        }
    }
}
