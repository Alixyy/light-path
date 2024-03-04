using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Burung
    {
        public string Nama;
        public string Latin;
        public string Warna;
        public string Ciri;
        public string Habitat;

        public Burung(string Nama, string Latin, string Warna, string Ciri,
            string Habitat)
        {
            this.Nama = Nama;
            this.Latin = Latin;
            this.Warna = Warna;
            this.Ciri = Ciri;
            this.Habitat = Habitat;

            Console.WriteLine($"Nama \t\t\t: {Nama}");
            Console.WriteLine($"Nama Latin \t\t: {Latin}");
            Console.WriteLine($"Warna \t\t\t: {Warna}");
            Console.WriteLine($"Karakteristik Utama \t: {Ciri}");
            Console.WriteLine($"Habitat \t\t: {Habitat}\n");
        }
    }
}
