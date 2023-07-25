class Kare
{
    private int _Kenar;
    public int Kenar
    {
        get { return _Kenar; }
        set
        {
            if (value < 1)
            {
                _Kenar = 1;
            }
            else
            {
                _Kenar = value;
            }
        }
    }
    public int CevreHesapla()
    {
        return 4 * _Kenar;
    }
    public void Hakkinda()
    {
        Console.WriteLine("Kenar = " + _Kenar + ", Cevre = " + CevreHesapla());
    }

}
class Program
{
    static void Main(string[] args)
    {
        Kare kare = new Kare();
        kare.Kenar = -10;
        kare.Hakkinda();
    }
}
