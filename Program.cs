using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuam 11)";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nama = "Aril Asghaf";
            karyawanTetap.Nik = "250-358";
            karyawanTetap.GajiBulanan = 6000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nama = "Narto Singkek";
            karyawanHarian.Nik = "260-222";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 10000;

            Sales sales = new Sales();
            sales.Nama = "Emilia Wulandari";
            sales.Nik = "101-502";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 40000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : Rp.{3 : 0}",
                    noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}