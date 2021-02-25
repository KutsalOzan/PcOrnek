using System;

namespace Calisma
{
   class Pc
    {
       static void Main(string[] args)
        {
            pctoplama kasa1 = new pctoplama();
            kasa1.ekrankart = "RTX2070";
            kasa1.anakart = "B450-F";
            kasa1.islemci = "i7";
            kasa1.ram = "32gb ram";
            kasa1.depolama = "SSD 500GB";
            Console.WriteLine(kasa1.ekrankart);
            Console.WriteLine("-------------------");
           
            pctoplama kasa2 = new pctoplama();
            kasa2.ekrankart = "GTX1080";
            kasa2.anakart = "B450M";
            kasa2.islemci = "i5";
            kasa2.ram = "16";
            kasa2.depolama = "1TB HDD";
            Console.WriteLine(kasa2.ekrankart);
        }


    }
     
}
