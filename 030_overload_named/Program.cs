class Program
{
    static void BaslikYaz(string baslik)
    {
        CizgiCiz(40);
        Console.WriteLine(baslik);
        CizgiCiz(40, "=");
    }
    static void CizgiCiz()
    {
        CizgiCiz(20, "-");
    }
    static void CizgiCiz(int cizgiUzunlugu)
    {
        CizgiCiz(cizgiUzunlugu, "-");
    }
    static void CizgiCiz(string cizgiKarakteri)
    {
        CizgiCiz(20, cizgiKarakteri);
    }
    static void CizgiCiz(int cizgiUzunlugu, string cizgiKarakteri)
    {
        for (int i = 0; i < cizgiUzunlugu; i++)
        {
            Console.Write(cizgiKarakteri);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        CizgiCiz();
        CizgiCiz("+");
        CizgiCiz(50);
        CizgiCiz(30, "*");
        //BaslikYaz("Merhaba Dünya");
        //Console.WriteLine("......");
        //Console.WriteLine("......");
        //Console.WriteLine("......");
        //CizgiCiz();
        //CizgiCiz(30);
    }
}