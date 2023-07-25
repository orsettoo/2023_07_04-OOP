class Program
{
    static void CizgiCiz(int cizgiUzunlugu=20, string cizgiKarakteri="-")
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
        CizgiCiz(40);
        CizgiCiz(cizgiKarakteri:"/",cizgiUzunlugu:15);
        CizgiCiz(30,"X");
    }
}
