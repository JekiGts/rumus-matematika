using System;
using Datar;
using Ruangan;

namespace HelloProgram
{
    class Program
    {
        static void Main(string[]args)
        {
            BangunDatar kelasku=new BangunDatar();

            Console.WriteLine("Kelasmu berada di X TKJ 1"+kelasku.tampilan()+"\n");

            kelasku.luas_persegi();
            kelasku.luas_segitiga();
            kelasku.luas_lingkaran();

            BangunRuang kelasku1=new BangunRuang();

            kelasku1.volume_balok();
            kelasku1.volume_kubus();
        }
    }
}