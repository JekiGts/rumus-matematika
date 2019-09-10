using System;

namespace Datar
{
    class BangunDatar
    {
        public string tampilan()
        {
            return ", Hello Jeki !";
        }
        public void luas_persegi()
        {
            int sisi,luas;

            Console.Write("Nilai sisi persegi adalah ");
            sisi=Convert.ToInt32(Console.ReadLine());

            luas=sisi*sisi;
            Console.WriteLine("Luas persegi adalah "+luas+"\n");
        }
        public void luas_segitiga()
        {
            int alas,tinggi;
            double luas;
            double setengah;
            setengah=0.5;

            Console.Write("Nilai alas segitiga adalah ");
            alas=Convert.ToInt32(Console.ReadLine());

            Console.Write("Nilai tinggi segitiga adalah ");
            tinggi=Convert.ToInt32(Console.ReadLine());

            luas=setengah*alas*tinggi;
            Console.WriteLine("Luas segitiga ini adalah "+luas+"\n");
        }
        public void luas_lingkaran()
        {
            int r;
            double luas;
            double phi;
            phi=3.14;

            Console.Write("Nilai jari-jari lingkaran adalah ");
            r=Convert.ToInt32(Console.ReadLine());

            luas=phi*r*r;
            Console.WriteLine("Luas lingkaran ini adalah "+luas+"\n");
        }
    }
}