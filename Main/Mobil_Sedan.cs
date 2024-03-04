using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Mobil_Sedan
    {
        public string Nama;
        public string Bahan_Bakar;
        public int Kapasitas_Tangki;
        public int Kapasitas_Mesin;
        public int Tempat_Duduk;

        public Mobil_Sedan(string Nama, string Bahan_Bakar, int Kapasitas_Tangki,
            int Kapasitas_Mesin, int Tempat_Duduk)
        {
            this.Nama = Nama;
            this.Bahan_Bakar = Bahan_Bakar;
            this.Kapasitas_Tangki = Kapasitas_Tangki;
            this.Kapasitas_Mesin = Kapasitas_Mesin;
            this.Tempat_Duduk = Tempat_Duduk;

            Console.WriteLine($"Nama Mobil \t\t: {Nama}");
            Console.WriteLine($"Bahan Bakar \t\t: {Bahan_Bakar}");
            Console.WriteLine($"Kapasitas Tangki \t: {Kapasitas_Tangki} liter");
            Console.WriteLine($"Kapasitas Mesin \t: {Kapasitas_Mesin} cc");
            Console.WriteLine($"Jumlah Tempat Duduk \t: {Tempat_Duduk} kursi\n");
        }
    }
}
