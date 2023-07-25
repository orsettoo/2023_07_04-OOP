class Kisi
{
    public string Adi;
    public string Soyadi;
    public int Yas;

    public void Selamla()
    {
        Console.WriteLine("merhaba ben , "+ Adi +" "+ Soyadi);
    }

    public void Tanit()
    {
        Selamla();
        Console.WriteLine(Yas+"yaşındayım");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kisi kisi1 = new Kisi();
        kisi1.Adi = "özge";
        kisi1.Soyadi = "doblan";
        kisi1.Yas = 17;
        kisi1.Selamla();
        

        Kisi kisi2 = new Kisi();
        kisi2.Adi = "ismail";
        kisi2.Soyadi = "Türkmen";
        kisi2.Yas = 18;
        kisi2.Selamla();
        Console.WriteLine("--------------------------------");
        kisi1.Tanit();
        kisi2.Tanit();
    }

    
    
}
