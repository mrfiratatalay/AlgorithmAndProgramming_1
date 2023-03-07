using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_2
{
    internal class Degiskenler
    {
        static void Main(string[] args)
        {
            string myName = "FIRAT";
            Console.WriteLine("My name is " + myName);
            myName = "FIRAT ATALAY";
            Console.WriteLine("My name is " + myName);
            Console.ReadKey();
            //Yukarda kendime string tipinde degisken olusturdum.

            int myNumber;
            myNumber = 0;
            Console.WriteLine( myNumber++);
            Console.WriteLine(myNumber *= 13);
            Console.WriteLine(myNumber= 13* myNumber);
            Console.ReadKey();
            //Yukarda yine int turunude bir degisken tanimlayip oynamalar yaptim.

        }

    }
}
