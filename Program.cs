using System;
namespace Metotlar
{
class Program
{
    static void Main(string[]args)
    {
        int a=2, b=5, c=3;
        Console.WriteLine(a+b+c);

        int sonuc=Topla(a,c);
        Console.WriteLine(sonuc);

        Metot ornek= new Metot();
        ornek.EkranaYazdirma(Convert.ToString(sonuc));
    }

    static int Topla(int sayi1, int sayi2)
    {
        return sayi1+sayi2;
    }
}
class Metot 
{
    public void EkranaYazdirma(string veri)
    {
        Console.WriteLine(veri);
    }
}
}