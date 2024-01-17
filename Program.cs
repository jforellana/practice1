using practice1;

public class Program
{
    private static void Main(string[] args)
    {
        PrintStuff ps;

        ps = new PrintStuff("SPA");

        System.Console.WriteLine("Please enter your name ");
        string name = "";
        name = System.Console.ReadLine();

        ps.PrintName(name);
    }
}