using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        int liczba = 1;
        do 
                {
            Console.WriteLine(Math.Pow(liczba, 2));

        }
        while ( liczba ++ < 20) ;
    }
}