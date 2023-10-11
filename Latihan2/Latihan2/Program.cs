using System;
using Latihan2.Honor;

namespace Latihan2
{
    class Program
    {
        static void Main(string[] args)
        {
            //mendeklarasikan objek dengan Class 
            HonorClass objHonor = new HonorClass();

            //index program
            Console.WriteLine("Aplikasi Penghitugan Honor Pengajar");
            Console.WriteLine("###################################");
            Console.Write("Nama Dosen                  : ");
            Console.ReadLine();
            Console.Write("Status Dosen (Tetap/Tidak)  : " );
            objHonor.status = Console.ReadLine();
            Console.Write("Pendidikan (S1/S2/S3)       : ");
            objHonor.pendidikan = Console.ReadLine();
            Console.Write("Jumlah SKS mengajar         : ");
            objHonor.inputSKS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("###################################");

            
            //proses
            Console.WriteLine("Hasil Penghitugan Honor Pengajar");
            Console.WriteLine("###################################");
            Console.WriteLine("Jumlah per SKS          : Rp." + objHonor.sks().ToString("N0"));
            Console.WriteLine("Tunjangan Fungsional    : Rp." + objHonor.tFunctional().ToString("N0"));
            Console.WriteLine("Uang Transport          : Rp." + objHonor.uTransport().ToString("N0"));
            Console.WriteLine("Total Honor Mengajar    : Rp." + objHonor.tHonorMengajar().ToString("N0"));
            Console.WriteLine("Total Pendapatan        : Rp." + objHonor.totalPendapatan().ToString("N0"));
            Console.WriteLine("###################################");
            Console.WriteLine("Jumlah Pph [-2%]        : -Rp." + objHonor.jPph().ToString("N0"));
            Console.WriteLine("###################################");
            Console.WriteLine("Total Honor Berdsih     : Rp." + objHonor.tDibayar().ToString("N0"));
            Console.WriteLine("###################################");

            Console.ReadKey();
        }
    }
}