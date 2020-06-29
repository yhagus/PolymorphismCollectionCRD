using System;
using System.Collections.Generic;
using PolymorphCollection.ClassAnak;
using PolymorphCollection.ClassInduk;

namespace PolymorphCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Karyawan> listKaryawan = new List<Karyawan>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tugas Lab 9 - Polymorphism, Abstraction, Collection - Create Read Delete\n");
                Console.WriteLine("\n1. Tambah Karyawan\n2. Hapus Karyawan\n3. Tampilkan Karyawan\n4. Exit Program\n");
                Console.Write("Pilihan [1 - 4] : ");
                string pilihan = Console.ReadLine();
                switch (pilihan)
                {
                    case "1":
                        //
                        //
                        Console.Clear();
                        Console.Write("\n\nMasukkan jenis karyawan [1. Karyawan tetap, 2. Karyawan harian, 3. Sales] : ");
                        string pilihKaryawan = Console.ReadLine();
                        switch (pilihKaryawan)
                        {
                            case "1":
                                //
                                //
                                KaryawanTetap karyawanTetap = new KaryawanTetap();

                                Console.Write("NIK: ");
                                karyawanTetap.Nik = Console.ReadLine();
                                Console.Write("Nama: ");
                                karyawanTetap.Nama = Console.ReadLine();
                                Console.Write("Gaji Bulanan: ");
                                karyawanTetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());

                                karyawanTetap.Tipe = "Karyawan tetap";
                                listKaryawan.Add(karyawanTetap);

                                Console.WriteLine("Press any key to return to menu . . .");
                                Console.ReadKey();
                                break;
                            case "2":
                                //
                                //
                                KaryawanHarian karyawanHarian = new KaryawanHarian();

                                Console.Write("NIK: ");
                                karyawanHarian.Nik = Console.ReadLine();
                                Console.Write("Nama: ");
                                karyawanHarian.Nama = Console.ReadLine();
                                Console.Write("Jumlah jam kerja: ");
                                karyawanHarian.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Upah per jam: ");
                                karyawanHarian.UpahPerJam = Convert.ToDouble(Console.ReadLine());
                                
                                karyawanHarian.Tipe = "Karyawan harian";
                                listKaryawan.Add(karyawanHarian);

                                Console.WriteLine("Press any key to return to menu . . .");
                                Console.ReadKey();
                                break;
                            case "3":
                                //
                                //
                                Sales sales = new Sales();

                                Console.WriteLine("Sales");
                                Console.Write("NIK: ");
                                sales.Nik = Console.ReadLine();
                                Console.Write("Nama: ");
                                sales.Nama = Console.ReadLine();
                                Console.Write("Jumlah penjualan: ");
                                sales.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Komisi: ");
                                sales.Komisi = Convert.ToDouble(Console.ReadLine());

                                sales.Tipe = "Sales";
                                listKaryawan.Add(sales);

                                Console.WriteLine("Press any key to return to menu . . .");
                                Console.ReadKey();
                                break;
                            default:break;

                        }

                        break;
                    case "2":
                        Console.Clear();
                        //
                        //
                        Console.Write("\n\nDelete by index");
                        Console.Write("\nIndex karyawan: ");
                        int delete = Convert.ToInt32(Console.ReadLine());
                        listKaryawan.RemoveAt((delete)-1);

                        break;
                    case "3":
                        Console.Clear();
                        //
                        //
                        //looping output
                        Console.Write("\n\n");
                        int i = 1;
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            Console.WriteLine(" {0}.\tIndex: {5}\n\tNIK: {1}\n\tNama: {2} \n\tGaji: {3:N0}\n\t{4}\n",
                                i, karyawan.Nik, karyawan.Nama, karyawan.Gaji(), karyawan.Tipe,i);
                            i++;
                        }
                        //
                        Console.WriteLine("Press any key to return to menu . . .");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("\n\n\nm@d3 by\nNama: Bagus Pranowo\nNIM: 19.11.2679\nKelas 19-IF-02\n\nPress any key to end process . . .");
                        Console.ReadKey();
                        return;
                        break;
                    default:break;
                }
            }
        }
    }
}
