using System;
public class Singleton
{
    private static Singleton singleton = new Singleton();
    private static int sayi = 0;

    public Singleton()
    {
        Console.WriteLine("Worked");
    }
    public static Singleton GetSingleton()
    {
        sayi++;
        Console.WriteLine(sayi);
        return singleton;
    }
}