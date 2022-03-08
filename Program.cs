namespace lineprogram;
public class program
{


    static void Main(string[] args)
    {
        double x1 = 1;
        double y1 = 1;
        double x2 = 4;
        double y2 = 4;
        double len = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("Length between two line" + len);

    }
}