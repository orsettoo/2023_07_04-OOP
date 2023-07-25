class Kisi
{
    private string _Adi;
    public string Adi
    {
        get { return _Adi; }
        set { _Adi = value; }
    }

    //public string Adi { get; set; }

    public string IkinciAdi { get; set; }
    public string Soyadi { get; set; }
    public string TamAdi
    {
        get
        {
            string sonuc = "";
            sonuc += Adi + " ";
            sonuc += IkinciAdi + " ";
            sonuc += Soyadi.ToUpper() + " ";
            return sonuc;
        }
    }
    public string GetTamAdi()
    {
        string sonuc = "";
        sonuc += Adi + " ";
        sonuc += IkinciAdi + " ";
        sonuc += Soyadi + " ";
        return sonuc;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kisi kisi = new Kisi();
        kisi.Adi = "Mehmet";
        kisi.IkinciAdi = "İsmail";
        kisi.Soyadi = "Tükmen";
        Console.WriteLine(kisi.TamAdi);
        Console.WriteLine(kisi.GetTamAdi());
    }
}
