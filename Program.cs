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

        string Name = "Taimour Sohail";
        string Address = "Bahria Town Karachi";
        string SchoolName = "Al-Nafi International College";
        int Age = 23;
        double latitude = 25.061284358312367;
        double longitude = 67.32018807120261;
        double[] coordinates = { latitude, longitude };
        char Gender = 'M';
        bool Student = true;


        Console.WriteLine("Name: " + Name + ", Address: " + Address + ", Age: " + Age + ", Location: " + latitude + "," + longitude + ", Single Char: " + Gender + ", Student: " + Student);
        Console.WriteLine();
        Console.WriteLine($"My is {Name}. I live in {Address} and I am {Age} Y/O, also I am student of {SchoolName} which is {Student}. \n My GPS coordinates: {coordinates[0]}, {coordinates[1]}");
        Console.WriteLine();

        // Type Casting:
        Console.WriteLine("Type Casting Lecture 👇");

        // --------Task 01

        int Count = 10;
        string Num = "100";
        int IntNum = Convert.ToInt32(Num);

        Console.WriteLine(IntNum - Count);

        // -------- Task 02 (Swap the Decimal Value )
        decimal Num1 = 10.2M; 
        int Num2 = 1;

        int Num3 = Convert.ToInt32(Num1);
        Num1 = Num2;
        Num2 = Num3;

        Console.WriteLine($"Variable1 = {Num1}, Variable2 = {Num2}");


        // -------- Task 03 (Change into Int)
        string CellNum = "03007836331";
        long NewNum = Convert.ToInt64(CellNum);

        Console.WriteLine("0"+NewNum);


        // -------- Task 04 (change into 0 / 1)
        bool gender = false;
        long answer = Convert.ToInt64(gender);

        Console.WriteLine(answer);

        // -------- Task 05 (Check the Case Sensitivity)
        int count1 = 100;
        int Count1 = 500;

        Console.WriteLine(Count1);

        // -------- Task 06 (Swap the Int Value)

        count1 = Count1;
        Console.WriteLine($"First Variable: {count1}, Second Variable: {Count1}");


        Console.ReadLine();
    }
}
