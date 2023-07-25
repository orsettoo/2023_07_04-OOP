using System.ComponentModel.Design;

class Musteri
{
    private string adsoyad;
    private int odano;

    public string Adsoyad

    {

        get
        {
            return adsoyad;
        }


        set
        {
            adsoyad = value;
        }


    }

    public int Odano
    {
        get
        {

            return odano;
        }
        set
        {

            if (value > 0 && value <= 200)
                odano = value;
            else
            {
                Console.WriteLine("Hata Oda numarası 200 den az olmalıdır");
                odano = -1;
            }


        }

    }



}


class Program
{
    static void Main(string[] args)
    {
        Musteri musteri = new Musteri();
        musteri.Adsoyad = "İsmail Türkmen";
        musteri.Odano = 55;
        Console.WriteLine(musteri.Odano);
        Console.WriteLine(musteri.Adsoyad);
        Console.WriteLine();
        musteri.Adsoyad = "İsmail Türkmen";
        musteri.Odano = 255;
        Console.WriteLine(musteri.Odano);
        Console.WriteLine(musteri.Adsoyad);

    }
}
