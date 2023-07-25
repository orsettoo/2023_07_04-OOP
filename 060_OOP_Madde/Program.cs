class Madde
{
    public string Adi = "";
    public int KN;
    public int DN;
    public int Sicaklik;


    public string MaddeninHali()
    {
        if (Sicaklik > KN)
        {
            return "GAZ";
        }
        else if (Sicaklik > DN)
        {
            return "SIVI";
        }
        else
        {
            return "KATI";
        }
        
    }
    public void DurumGoster()
    {
        Console.WriteLine(Adi + " ,\t " + Sicaklik + " derecede " + MaddeninHali()+" Haldedir ");
       
    }
}

class Program
{
    static void Main(string[] args)
    {
        Madde madde1 = new Madde();
        madde1.Adi = "Su";
        madde1.KN = 100;
        madde1.DN = 0;
        

        Madde madde2 = new Madde();
        madde2.Adi = "Alkol";
        madde2.KN = 80;
        madde2.DN = -20;

        Madde madde3= new Madde();
        madde3.Adi = "Demir";
        madde3.KN = 3000;
        madde3.DN = 1500;

        madde1.Sicaklik = madde2.Sicaklik = madde3.Sicaklik = 5000;

        madde1.DurumGoster();
        madde2.DurumGoster();
        madde3.DurumGoster();
    }
}
