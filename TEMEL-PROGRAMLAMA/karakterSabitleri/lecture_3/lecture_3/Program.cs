using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myLifeSituation();
        }

        private static void myLifeSituation()
        {
            string myName = "Firat";
            string myJob = "Teacher";
            int mySalary = 13;
            Console.WriteLine("My name is " + myName + " and I am a professional " + myJob +
                " I am working for " + mySalary + " dollars");
            Console.ReadKey();
        }

        /*
          static void Main(string[] args)
        {
            string myName = "Firat";
            string myJob = "Teacher";
            int mySalary = 13;
            Console.WriteLine("My name is " + myName + " and I am a professional " + myJob +
                " I am working for " + mySalary + " dollars");
            Console.ReadKey();
        }

        Bu ustteki yazmis oldugum kodlari ctr ile toplu secerek klavyemde "CTRL+ ." butonuna basip hazir
        bir fonksiyona donusturdum ve ismine "myLifeSituation" dedim.Bu olayi JavaScriptten'de hatirlayacagin
        uzere "REFACTORUNG" 'tir.
        */
    }
}
