using System;
using System.Globalization;

public class URI_1113
{
    public static void Main(string[] args)
    {
        int x, y;
        string[] valores = Console.ReadLine().Split(' ');

        x = int.Parse(valores[0], CultureInfo.InvariantCulture);
        y = int.Parse(valores[1], CultureInfo.InvariantCulture);

        while (x != y)
        {
            if (x < y)
            {
                Console.WriteLine("Crescente");
            }
            else
            {
                Console.WriteLine("Decrescente");
            }

            valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0], CultureInfo.InvariantCulture);
            y = int.Parse(valores[1], CultureInfo.InvariantCulture);
        }
    }
}