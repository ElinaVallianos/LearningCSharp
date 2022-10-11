internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        float a = 10000.1f;
        float b = 10000.01f;

        double c = 0.123451;
        b = (float)c;
        Console.WriteLine(c);

        byte b1 = 15;
        int i1;

        i1 = ++b1;
        Console.WriteLine(b1);
        Console.WriteLine(i1);

        int i2 = 4;
        int i3 = 11;


        Console.WriteLine(i3/i2);
        Console.WriteLine(i3%i2);

        Console.WriteLine("Enter your number: ");
        string input = Console.ReadLine();
        i3 = int.Parse(input);
        Console.WriteLine($"You enter: {i3} ");
        //Console.WriteLine(i3);
    }
}