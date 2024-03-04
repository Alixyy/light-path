using Main;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("MOBIL SEDAN");
        Mobil_Sedan mercedes = new Mobil_Sedan("Mercedes Benz C-Class Sedan C 300 AMG Line",
            "Bensin", 66, 1999, 5);
        Mobil_Sedan civic = new Mobil_Sedan("Honda Civic RS", "Bensin", 47, 1498, 5);
        Mobil_Sedan audi = new Mobil_Sedan("Audi A6", "Bensin", 65, 1798, 5);

        Console.WriteLine("IKAN");
        Ikan badut = new Ikan("Badut", "Amphiprioninae", "Pomacentridae", "Laut");
        Ikan lele = new Ikan("Lele", "Clarias Batrachus", "Clariidae", "Air Tawar");
        Ikan gabus = new Ikan("Gabus", "Channa striata", "Channidae", "Air Tawar");

        Console.WriteLine("BURUNG");
        Burung cendrawasih = new Burung("Cendrawasih", "Paradisaea raggiana", "Merah, Kuning",
            "Warna bulu yang mencolok", "Dataran rendah, Hutan hujan tropis, dan Daerah hutan sekunder");
        Burung jalakBali = new Burung("Jalak Bali", "Leucopsar rothschildi", "Putih",
            "Dapat menirukan suara manusia dan suara lingkungan sekitar",
            "Hutan bagian barat Pulau Bali");
        Burung elangJawa = new Burung("Elang Jawa", "Nisaetus bartelsi", "Putih, Coklat Gelap, Hitam",
            "Kepala dan leher berwarna putih, sedangkan bagian tubuh lainnya\n\t\t\t  didominasi oleh warna cokelat gelap atau hitam",
            "Hutan-hutan pegunungan, Hutan primer, dan Hutan sekunder di dataran tinggi");

        Console.WriteLine("KOMPUTER");
        Komputer acer = new Komputer("PC Acer Aspire TC-875", 8, 1, "Intel Core i7", "Acer LED Monitor 19.5″ inch",
           "Nvdia Geforce GT730");
        Komputer asus = new Komputer("PC Asus S500TC-341000002W", 4, 1, "Intel Core i3", "Asus LED Monitor 19.5″ inch",
            "Intel UHD Graphics 610");
        Komputer lenovo = new Komputer("PC Lenovo AIO V530-24ICB-10UWA00DID", 8, 1, "Intel Core i5",
            "23.8-inch FHD (1920 x 1080) Anti-Glare Narrow Border Infinity Non-Touch Display", "Intel HD Graphics");
    }
}