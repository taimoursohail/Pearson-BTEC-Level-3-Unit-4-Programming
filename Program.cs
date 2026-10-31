namespace Unit4Programming;

public static class Program
{
    public static void Main(string[] args)
    {
        /* Data types
           Testig Variables:
            - Premitive Data Types (Actually Value Types)
            1) string
            2) int
            3) double
            4) char
            5) bool
         */

        int integerNumbers = 10;
        decimal myDecimalNumber = 99.99m;
        char singleChar = 'A';
        const string name = "Taimour Sohail"; // const make the value immutable
        bool boolVal = true;

        Console.WriteLine($"{integerNumbers}, {myDecimalNumber}, {singleChar}, {name}, {boolVal}");

        Console.ReadLine();
    }
}
