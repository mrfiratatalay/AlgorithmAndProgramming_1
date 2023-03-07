using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture
{
    /*
    ***********************************************************************************
    Kendime bir struck yapisi olusturmak istiyorsam,asagidaki iskeleti kullanicam;

    public struct "Buyuk harfle strucktinin adini yaz"
    {
        //Iceriye property eklemek istersem klavyemde "prop+TAB" hazir snipi kullanicam.
        //Iceriye constructor function ya da methodlar ekleyebilirim.
    }
    **************************************************************************************
    **************************************************************************************
    
      public struct MyInformation
    {
        public string myName { get; set; }
        public string myJob { get; set; }
        public int myAge { get; set; }

    }

    Bu ustte konunun en basinda ogrendigim sekilde kendime bir struct yapisi olusturdum.
    Farkindaysan buradaki property'lerimi public olarak belirledim. Cunku bu verileri
    farkli domainlerimde de kullanmak istiyorum.Eger private yapsaydim sade bu struct'imin
    icerisinde bu verilere erisebilirdim.
    Ayrica farkindaysan her property'im GET ve SET'lerden olusuyor. Bu ne anlama geliyor?
    GET ile o veriyi okuma, SET ile de o veriyi yazma yani degistirme islemlerine onay vermis
    oluyorum.

    ***************************************************************************************
    ***************************************************************************************
    
    public struct MyInformation
    {
        public string myName { get; set; }
        public string myJob { get; set; }
        public int myAge { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
           MyInformation myPersonality = new MyInformation();
            myPersonality.myName = "Firat";
            myPersonality.myJob = "Software Developer";
            myPersonality.myAge = 22;

            Console.WriteLine(myPersonality.myName);
            Console.ReadKey();
        }
    }
        
    Burda class'imin icinde sahip oldugum struct yapimi kullanarak kendime farkli turde
    veriler urettim.Peki bunu nasil yapabilirim?

    1.YOL**
    *******
    

    //Once  new keyword'umu kullanarak sahip oldugum structtan objemi olusturdum.
    MyInformation myPersonalatiy = new MyInformation();

    //Sonra olusturmus oldugum objemin sahip olmus oldugu property'lere istedigim
    //degerleri atadim.
    myPersonality.myName = "Firat";
    myPersonality.myJob = "Software Developer";
    myPersonality.myAge = 22;

    //Konsolumda da cok rahat bu property'lere ulasabiliyorum.
    Console.WriteLine(myPersonality.myName);



    2.YOL**
    *******
    
    
    var myPersonality2 = new MyInformation()
            {
                myName = "DILEK",
                myJob = "KING",
                myAge = 40
            };
            Console.WriteLine(myPersonality2.myName);
            Console.ReadKey();
    
    *****************************************************************************
    **********************************************************************************
    *
    3.YOL**
    *******

     
        //Klavyemde bu asagidaki struct'imin icinde bulunan propertylerimin bulundugu
        kismi ---- 3 yildiz arasina aldigim kismi -- secersem sonra "CTRL+ ." ya basarsam bu
        propertylerin benim icin structimla ayni isme sahip constructor functiona 
        donusmus halini elde ederim.

        ***
        public string myName { get; set; }
        public string myJob { get; set; }
        public int myAge { get; set; }
        ***
        

        YANI BU ASAGIDAKI KODU ELDE EDECEGIM..

        public MyInformation(string myName, string myJob, int myAge)
        {
            this.myName = myName;
            this.myJob = myJob;
            this.myAge = myAge;
        }

        YANI ISIN SONUNDA SAHIP OLDUGUM STRUCT ASAGIDAKI BICIMDE GOZUKECEK
        
        public struct MyInformation
        {
            public MyInformation(string myName, string myJob, int myAge)
            {
            this.myName = myName;
            this.myJob = myJob;
            this.myAge = myAge;
            }

            public string myName { get; set; }
            public string myJob { get; set; }
            public int myAge { get; set; }

    }

        Tabi sende biliyorsun ki "this" keywordum her zaman zaten struct'imin kendisine yani
    "MyInformation" a isaret ediceginden aslinda this keyword'larini kullanmana gerek yok.
    
        public MyInformation(string myName, string myJob, int myAge)
            {
                myName = myName;
                myJob = myJob;
                myAge = myAge;
            }

    TUM BUNLARI STRUCT'IMIN ICINDE YAPTIKTAN SONRA ARTIK CLASS'IMIN ICINDE BU CONSTRUCTOR
    FUNCTIONUMU KULLANABILIRIM.

            var myPersonality3 = new MyInformation("ESLEM", "Doctor", 11);
            Console.WriteLine(myPersonality3.myName);
            Console.ReadKey();
    */
    public struct MyInformation
    {
        public MyInformation(string myName, string myJob, int myAge)
        {
            this.myName = myName;
            this.myJob = myJob;
            this.myAge = myAge;
        }

        public string myName { get; set; }
        public string myJob { get; set; }
        public int myAge { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //1.YOL**
            MyInformation myPersonality = new MyInformation();
            myPersonality.myName = "Firat";
            myPersonality.myJob = "Software Developer";
            myPersonality.myAge = 22;
            Console.WriteLine(myPersonality.myName);
            Console.ReadKey();

            //2.YOL**
            var myPersonality2 = new MyInformation()
            {
                myName = "DILEK",
                myJob = "KING",
                myAge = 40
            };
            Console.WriteLine(myPersonality2.myName);
            Console.ReadKey();

            //3.YOL**
            var myPersonality3 = new MyInformation("ESLEM", "Doctor", 11);
            Console.WriteLine(myPersonality3.myName);
            Console.ReadKey();


        }
    }
}
