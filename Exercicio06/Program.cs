internal class Program
{
    static void Main(string[] args)
    {
        int a, b, temp;

        a = 1;
        b = 2;
        Console.WriteLine($"a = {a}, b = {b}");
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"a = {a}, b = {b}");
    }
}
