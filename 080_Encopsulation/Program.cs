class Calisan
{
    public string Adi;
    private int ToplamPara=500;
    private int Maas=100;

    public void MaasAl()
    {
        ToplamPara += Maas;
    }

    public void FinansalDurum()
    {
        Console.WriteLine("Ben "+Adi + " Toplam "+ToplamPara+" Param Var ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan();
        calisan1.Adi = "İsmail Türkmen";
        calisan1.MaasAl();
        calisan1.MaasAl();
        Console.WriteLine();


        calisan1.FinansalDurum();


    }
}
