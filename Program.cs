using System;

class Program
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Provide a number to preform the addition operation.");
        int num0 = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide a number to add to " + num0 + ".");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine(num0 + num1);

        Console.WriteLine("Provide a number to preform the subtraction operation.");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide a number to subtract to " + num2 + ".");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine(num2 - num3);

        Console.WriteLine("Provide a number to preform the multiplication operation.");
        int num4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide a number to multiply to " + num4 + ".");
        int num5 = int.Parse(Console.ReadLine());
        Console.WriteLine(num4 * num5);

        Console.WriteLine("Provide a number to preform the division operation.");
        int num6 = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide a number to divide to " + num6 + ".");
        int num7 = int.Parse(Console.ReadLine());
        Console.WriteLine(num6 / num7);

        Console.WriteLine("Provide a number to preform the addition operation.");
        float num8 = float.Parse(Console.ReadLine());
        Console.WriteLine("Provide a number to add to " + num8 + ".");
        float num9 = float.Parse(Console.ReadLine());
        Console.WriteLine(num8 + num9);
    }
}