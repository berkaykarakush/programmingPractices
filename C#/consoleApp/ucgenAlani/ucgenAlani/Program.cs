using System;

namespace ucgenAlani
{
    class Program
    {
        static void Main(string[] args)
        {
            //ucgen alanini hesaplayan program
            Console.Write("Ucgenin kenar degerini giriniz: ");
            int kenar = int.Parse(Console.ReadLine()); //kenar yukseklik degerini int'a cast et ve kenar degiskenine ata
            Console.Write("Ucgenin yuksekligini degerini giriniz: ");
            int yukseklik = int.Parse(Console.ReadLine());

            Console.WriteLine(kenar *yukseklik/2);//alan=kenar*yukseklik/2
        }
    }
}
