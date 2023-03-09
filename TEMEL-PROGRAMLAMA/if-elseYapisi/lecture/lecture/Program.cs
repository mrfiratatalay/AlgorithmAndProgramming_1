using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private static void myValue()
        {
            //Console.WriteLine(Console.Read()) ;
            ////"Console.Read" ile klavyemde girilen degerin ascii'ye gore
            ////onluk sistemdeki karsiligini vericektir..
            //*****************************************

            Console.WriteLine("Can you press keyword?");
            var myValue = (char)Console.Read();

            if (char.IsDigit(myValue))
            {
                Console.WriteLine(char.IsDigit(myValue));
            }
            else if (char.IsLower(myValue))
            {
                Console.WriteLine(char.IsLower(myValue));
            }
            else if (char.IsUpper(myValue))
            {
                Console.WriteLine(char.IsUpper(myValue));
            }
            else
            {
                Console.WriteLine("Invalid character..");
            }


            Console.ReadKey();
        }

        private static void absoluteValue()
        {
            //My aim is to find out the gender of the number
            //entered using the if-else statement.
            //****************************************
            Console.WriteLine("Can you type a number?");
            int myNumber2 = Convert.ToInt32(Console.ReadLine());
            if (myNumber2 > 0)
            {
                Console.WriteLine($"|{myNumber2}| = {myNumber2}");
            }
            else
            {
                Console.WriteLine($"|{myNumber2}| = {myNumber2 * -1}");
            }
            Console.ReadKey();
        }

        private static void myNumberGender()
        {
            //My aim is to find out the gender of the number
            //entered using the if-else statement.
            //****************************************


            Console.WriteLine("Can you type a number:)");
            //Bir sayi giriniz
            int myNumber = Convert.ToInt32(Console.ReadLine());
            //Girilen sayi Console.ReadLine ile alindigi zaman
            //bu deger string biciminde olucagindan,
            //"Convert.ToInt32" diyerek number donusumu yaptim.

            if (myNumber % 2 == 0)
            {
                Console.WriteLine($"My number ({myNumber}) is even..");
            }
            else
            {
                Console.WriteLine($"My number ({myNumber}) is odd..");
            }

            Console.ReadKey();
        }

    }
}
