using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Ikan
    {
        public string Nama;
        public string Ilmiah;
        public string Famili;
        public string Habitat;

        public Ikan(string Nama, string Ilmiah, string Famili,
            string Habitat)
        {
            this.Nama = Nama;
            this.Ilmiah = Ilmiah;
            this.Famili = Famili;
            this.Habitat = Habitat;

            Console.WriteLine($"Nama Ikan \t: {Nama}");
            Console.WriteLine($"Nama Ilmiah \t: {Ilmiah}");
            Console.WriteLine($"Famili \t\t: {Famili}");
            Console.WriteLine($"Habitat \t: {Habitat}\n");
        }
    }
}
