using System;
using System.Collections.Generic;

namespace Collection
{
    public class KaryawanTetap : Karyawan
    {
        public override string Nama { get; set; }
        public override string Nik { get; set; }
        public double GajiBulanan { get; set; }

        public override double Gaji() 
	{
	   return GajiBulanan;
	}
    }
}