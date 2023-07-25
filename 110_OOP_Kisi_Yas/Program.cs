class Kisi
{
    public string Adi { get; set; }
    public int DogumYili { get; set; }

    public int yas

    {

        get
        {
             return DateTime.Now.Year - DogumYili;
        }

    }

}


class Program
{
    static void Main(string[] args)
    {
        Kisi kisi = new Kisi();
        kisi.Adi = "Kubra";
        kisi.DogumYili = 2000;
        Console.WriteLine(kisi.yas);
    }
}
