using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Komputer
    {
        public string Nama;
        public int Ram;
        public int Storage;
        public string Processor;
        public string Monitor;
        public string Graphic;

        public Komputer(string Nama, int Ram, int Storage,
            string Processor, string Monitor, string Graphic)
        {
            this.Nama = Nama;
            this.Ram = Ram;
            this.Storage = Storage;
            this.Processor = Processor;
            this.Monitor = Monitor;
            this.Graphic = Graphic;

            Console.WriteLine($"Nama \t\t: {Nama}");
            Console.WriteLine($"RAM \t\t: {Ram} GB");
            Console.WriteLine($"Storage \t: {Storage} TB");
            Console.WriteLine($"Processor \t: {Processor}");
            Console.WriteLine($"Monitor \t: {Monitor}");
            Console.WriteLine($"Graphic \t: {Graphic}\n");
        }
    }
}
