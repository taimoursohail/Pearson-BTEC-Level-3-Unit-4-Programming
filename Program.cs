namespace Unit4Programming;

public static class Program
{
    public static void Main(string[] args)
    {
        /* Understanding Data types and Variable Concept
           - Variables
            - Premitive Data Types (Actually Value Types)
            1) string
            2) int
            3) double
            4) char
            5) bool
         */

        int integerNumbers = 10;
        decimal myDecimalNumber = 99.99m;
        double myDoubleNumber = 99.99999999999999999999D;
        char singleChar = 'A';
        const string name = "Mr. Taimour Sohail"; // const make the value immutable
        bool boolVal = true;

        string name2 = "Taimour Sohail";
        string address = "Bahria Town Karachi";
        int age = 23;
        double doubleval = 999.99;
        char gender = 'M';
        bool student = true;


        Console.WriteLine($"{integerNumbers}, {myDecimalNumber}, {myDoubleNumber}, {singleChar}, {name}, {boolVal}");
        Console.WriteLine("Name: " + name2 + ", Address: " + address + ", Age: " + age + ", Bank Balance: " + doubleval + ", Single Char: " + gender + ", Student: " + student);

        Console.ReadLine();
    }
}
