class Program
{
    static string Adınıgir(string isim)
    {

        return isim;
    }
    
    static int yasigir(int yas)
    {
        return yas;
    }
    
    static int dogumtarihi(int dogum)
    {
        return dogum;
    }
    
    static string egitimdurumu(string egitim)
    {
        return egitim;
    }
    
    static int kuphesapla(int sayi)
    {
        int sonuc = 0;
        sonuc = sayi * sayi * sayi;
        return sonuc;

    }
    static void Main(string[] args)
    {
        Console.WriteLine("adınızı girin :");
        string isim=Console.ReadLine();
       
       
        Console.WriteLine("yaşınızı girin :");
        int yas=int.Parse(Console.ReadLine());

        Console.WriteLine("Doğum tarihinizi girin :");
        int dogum=int.Parse(Console.ReadLine());

        Console.WriteLine("Eğitim Durumunuzu Girin :");
        string egitim=Console.ReadLine();

       
        
        Console.WriteLine("sayı giriniz");
        int sayi =int.Parse(Console.ReadLine());
        Console.WriteLine(kuphesapla(sayi));

        Console.WriteLine("Bilgiler İçin Teşekkürler");
    }
}
