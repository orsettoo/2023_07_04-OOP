class Kare
{
    public int Kenar;
    public int AlanHesapla()
    {
        return Kenar*Kenar;


    }
    
    
    

    
    
    public void Hakkında()
    {
        Console.WriteLine("Kenar = "+ Kenar+"cm,Alan"+AlanHesapla());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kare kare= new Kare();
        kare.Kenar = 10;
        kare.Hakkında();
    }
}
