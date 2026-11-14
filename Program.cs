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

        /*
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

        */

        // Append or String Concatination:
        Console.WriteLine("Concetination/Append Lecture 👇");
        Console.WriteLine();

        string Name = "TAIMOUR";
        string FatherName = "SOHAIL";
        string Cell = "03207882433";
        string Address = "Precinct 02 Bahria Town Karachi, Karachi";

        string HighestGrade = "Matric";
        int GraduationYear = 2022;
        string InstitueName = "White House Grammer School";

        string Vision = "To become Software Engineer";

        string Hobby1 = "Golfing";
        string Hobby2 = "Coding";

        string NextOfKin = "Brother";
        string ProgrammingLanguage = "C#";

        string Skill = "Website Development";
        int YearsOfExperiance = 1;

        Console.WriteLine("_______________________________");
        Console.WriteLine("     Personal Information      ");
        Console.WriteLine("_______________________________");
        Console.WriteLine("Name: " + Name.ToUpper());
        Console.WriteLine("Father Name: " + FatherName.ToUpper());
        Console.WriteLine("Cell Phone Number: " + Cell);
        Console.WriteLine("Address: " + Address);
        Console.WriteLine();

        Console.WriteLine("          Qualification        ");
        Console.WriteLine("_______________________________");
        Console.WriteLine($"Highest Qualification is {HighestGrade} and had completed in {GraduationYear} at {InstitueName}.");
        Console.WriteLine();

        Console.WriteLine("            Vision             ");
        Console.WriteLine("_______________________________");
        Console.WriteLine(Vision);
        Console.WriteLine();

        Console.WriteLine("            Hobbies            ");
        Console.WriteLine("_______________________________");
        Console.WriteLine($"My Hobbies are {Hobby1} and {Hobby2}");
        Console.WriteLine();

        Console.WriteLine("          Next of Kin          ");
        Console.WriteLine("_______________________________");
        Console.WriteLine($"My next of Kin is my {NextOfKin}");
        Console.WriteLine();

        Console.WriteLine("          Experience           ");
        Console.WriteLine("_______________________________");
        Console.WriteLine($"I am learning {ProgrammingLanguage} programming language.");
        Console.WriteLine();

        Console.WriteLine("             Skills            ");
        Console.WriteLine("_______________________________");
        Console.WriteLine($"I have {YearsOfExperiance} years of experiance in {Skill} field");
        Console.WriteLine();

        Console.ReadLine();
    }
}
