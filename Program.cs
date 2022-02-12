using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan.calisanekle("mehmet");
            Calisan.calisanekle("ömer");
            Calisan.calisanekle("miyem");
            Calisan.calisanekle("memo");
            Console.WriteLine(Calisan.calisansayisi);
            Console.ReadLine();
        }
    }

    public static class Calisan
    {
        public static int calisansayisi;
        public static string ad;

        public static void  calisanekle (string xyz)
        {
            ad = xyz;
            calisansayisi++;
        }

        static Calisan()
        {
            calisansayisi = 0;
                 
        }


    }
}
