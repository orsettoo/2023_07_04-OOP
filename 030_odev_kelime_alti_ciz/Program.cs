{
    static bool SesliMi(char karakter)
    {
        bool sonuc = false;
        string sesliler = "AaEeıIiİUuÜüOoÖö";
        for (int i = 0; i < sesliler.Length; i++)
        {
            if (sesliler[i] == karakter)
            {
                sonuc = true;
                break;
            }
        }
        return sonuc;
    }
    static void KelimelerinAltiniCiz(string cumle)
    {
        Console.WriteLine(cumle);
        for (int i = 0; i < cumle.Length; i++)
        {
            if (cumle[i] == ' ')
                Console.Write(' ');
            else
                Console.Write('-');
        }
    }

    static void KelimelerinAltiniCiz2(string cumle)
    {
        Console.WriteLine(cumle);
        for (int i = 0; i < cumle.Length; i++)
        {
            if (cumle[i] == ' ')
            {
                Console.Write(' ');
            }
            else if (SesliMi(cumle[i]))
            {
                Console.Write('+');
            }
            else
            {
                Console.Write('-');
            }
        }
    }

    static void Main(string[] args)
    {
        KelimelerinAltiniCiz("Hello New World!");
        Console.WriteLine(); Console.WriteLine();
        KelimelerinAltiniCiz2("Hello New World!");
    }
}

