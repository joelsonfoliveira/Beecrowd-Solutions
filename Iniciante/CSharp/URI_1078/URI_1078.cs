using System;
using System.Globalization;

public class URI_1078
{
    public static void Main(string[] args)
    {
        int N;

        N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        for (int i = 1; i <= 10; i++)
        {
            int resultado = i * N;
            Console.WriteLine(i + " x " + N + " = " + resultado);
        }
    }
}