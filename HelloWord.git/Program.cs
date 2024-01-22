using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti primul numar intreg:");
        int numar1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea numar intreg:");
        int numar2 = int.Parse(Console.ReadLine());

        int suma = numar1 + numar2;

        Console.WriteLine($"Rezultatul adunarii este: {suma}");
    }
}

