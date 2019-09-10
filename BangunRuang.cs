using System;

namespace Ruangan
{
    class BangunRuang
    {
        public void volume_balok()
        {
            int panjang,lebar,tinggi,volume;

            Console.Write("Nilai panjang balok adalah ");
            panjang=Convert.ToInt32(Console.ReadLine());

            Console.Write("Nilai lebar balok adalah ");
            lebar=Convert.ToInt32(Console.ReadLine());

            Console.Write("Nilai tinggi balok ini adalah ");
            tinggi=Convert.ToInt32(Console.ReadLine());

            volume=panjang*lebar*tinggi;
            Console.WriteLine("Volume Balok ini adalah "+volume+"\n");
        }
        public void volume_kubus()
        {
            int sisi,luas;

            Console.Write("Nilai sisi kubus ini adalah ");
            sisi=Convert.ToInt32(Console.ReadLine());

            luas=sisi*sisi*sisi;
            Console.WriteLine("Volume kubus ini adalah "+luas+"\n");
        }
    }
}