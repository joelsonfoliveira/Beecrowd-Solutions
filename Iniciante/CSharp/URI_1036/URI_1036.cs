public class URI_1036
{
    public static void Main(string[] args)
    {
        Console.WriteLine("URI 1036");

        double a, b, c, delta, r1, r2;
        string[] valores = Console.ReadLine().Split(' ');

        a = double.Parse(valores[0]);
        b = double.Parse(valores[1]);
        c = double.Parse(valores[2]);

        delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta < 0 || a == 0)
        {
            Console.WriteLine("Impossivel calcular");
        } else
        {
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("R1 = " + r1.ToString("F5"));
            Console.WriteLine("R2 = " + r2.ToString("F5"));
        }
    }
}
