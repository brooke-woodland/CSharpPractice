internal class Program
{
    private static void Main(string[] args)
    {
        int num = int.Parse(args[1]);
        System.Console.WriteLine(args[1] + " squared is " + num * num);
        System.Console.WriteLine("Hello, " + args[0] +"!");
    }
}