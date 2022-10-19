internal class Program
{
    private static void Main(string[] args)
    {
        basla:
        string input = "";
        Console.WriteLine("kelime giriniz");
        input = Console.ReadLine();
        

        for (int i = 1; i < input.Length; i++)
        {
            Console.Write(input[i]);
        }
        Console.Write(input[0]);
        Console.WriteLine("");
        goto basla;
    }
}