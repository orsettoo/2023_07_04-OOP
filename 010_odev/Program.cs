using System.Runtime.InteropServices;

class Program
{
    static string Selamla(string isim)
    {

        return isim;
    }
    
    static string Selamla(string isim, string soyisim)
    {
        return isim + soyisim;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine( "hoşgeldin " + Selamla("Yavuz"));
        Console.WriteLine("hoşgeldin " + Selamla("Yavuz" , "Işık"));
        Console.WriteLine("----------------------------------------------------------");
    }
}




