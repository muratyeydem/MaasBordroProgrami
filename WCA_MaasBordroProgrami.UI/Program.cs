using CSProjeDemo2.Entities.Abstract;
using CSProjeDemo2.Helper;

public class Program
{
    static void Main(string[] args)
    {// JSON dosyasından personel listesini oku
        DosyaOku dosyaOku = new DosyaOku();
        List<Personel> personelListesi = dosyaOku.PersonelListesiOku(@"C:\Users\murat\Desktop\.Net Kursu BilgeAdam\MaasBordoSistemi\JsonVeri.json");//buradaki link değişken

        // Maaş bordrosunu oluştur
        MaasBordro maasBordro = new MaasBordro();
        string maasRaporu = maasBordro.BordroOlustur(personelListesi, @"C:\Users\murat\Desktop\.Net Kursu BilgeAdam\MaasBordoSistemi\MaasBilgisi");//buradaki link değişken

        // Raporu yazdır
        Console.WriteLine("Maaş Raporu:");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(maasRaporu);


        // 150 saat az çalışan personellerin bilgilerini belirt
        foreach (var personel in personelListesi)
        {
            if (personel.MaasHesapla(200) < personel.SaatlikUcret * 150)
            {
                Console.WriteLine($"{personel.Ad} 150 saatten az çalıştı!");
            }
        }


        Console.ReadLine();
    }
}