// See https://aka.ms/new-console-template for more information
public class penjumlahan
{
    public T JumlahTigaAngka<T>(T num1, T num2, T num3)
    {
        dynamic number1 = num1;
        dynamic number2 = num2;
        dynamic number3 = num3;
        return number1 +number2 +number3;
    }
}

public class program
{
    public static void Main(string[] args)
    {
        penjumlahan jum = new penjumlahan();
        int a = 13;
        int b = 02;
        int c = 21;
        Console.WriteLine(jum.JumlahTigaAngka(a, b, c));

    }
}