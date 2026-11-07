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


        Console.WriteLine("Name: " + Name + ", Address: " + Address + ", Age: " + Age + ", Location: " + latitude+","+longitude  + ", Single Char: " + Gender + ", Student: " + Student);
        Console.WriteLine();
        Console.WriteLine($"My is {Name}. I live in {Address} and I am {Age} Y/O, also I am student of {SchoolName} which is {Student}. \n My GPS coordinates: {coordinates[0]}, {coordinates[1]}");

        Console.ReadLine();
    }
}
