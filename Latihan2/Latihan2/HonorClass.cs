using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Latihan2.Honor
{
    class HonorClass
    {
        public string? status;
        public string? pendidikan;
        public int inputSKS;
        

        //tunjangan fungsional
        public int tFunctional()
        {
            if (status! == "Tetap" || status! == "tetap") {
                return 325000;
            }
            else if (status! == "Tidak" || status == "tidak")
            {
                return 0;
            }   
            else { return 0; }
        }

        //uang transport
        public int uTransport ()
        {
            if (status! == "Tetap" || status! == "tetap")
            {
                return 0;
            }
            else if (status! == "Tidak" || status! == "tidak") {
                return 250000;
            }
            else
            {
                return 0;
            }
        }
       

        //honor per sks
        public int sks()
        {
            if (pendidikan! == "S1")
            {
                return 20000;
            }
            else if (pendidikan! == "S2")
            {
                return 25000;
            }
            else if (pendidikan! == "S3")
            {
                return 30000;
            }
            else
            {
                return 0;
            }
        }

        //total honor mengajar
        public int tHonorMengajar()
        {
            if (sks() == 20000)
            {
                return inputSKS * sks();
            }
            else if (sks() == 25000)
            {
                return inputSKS * sks();
            }
            else if (sks() == 30000)
            {
                return inputSKS * sks();
            }
            else
            {
                return inputSKS * 0;
            }
        }

        //total pendapatan
        public int  totalPendapatan()
        {
            return tHonorMengajar() + tFunctional() + uTransport();
        }

        //jumlah pph
        public double jPph()
        {
            double Pph = 0.02;
            return totalPendapatan() * Pph;
        }

        //total yang dibayarkan
        public double tDibayar ()
        {
            return totalPendapatan() - jPph();
        }
    }
}
