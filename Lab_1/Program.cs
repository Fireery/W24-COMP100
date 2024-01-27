public class Lab_1
{
    public static void Main(string[] args)
    {
        //Program Infor
        Console.WriteLine("Lab 1 - Data Type \tYixin Rong \t#301395073");
        //Q1
        Console.WriteLine("\nQuestion 1:");
        //Inputs
        Console.WriteLine($"Enter your first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Enter your middle name: ");
        string middleName = Console.ReadLine();
        Console.WriteLine($"Enter your last name: ");
        string lastName = Console.ReadLine();
        //Outputs
        Console.WriteLine($"\n" + firstName + " " + lastName);
        Console.WriteLine($"" + firstName + " " + middleName + " " + lastName);
        Console.WriteLine($"" + lastName + ", " + firstName + " " + middleName);
        //break sec
        Console.WriteLine("\n\n\nPress any key to continue...\n");
        Console.ReadKey();
        //Q2
        Console.WriteLine("\nQuestion 2:");
        //Input
        Console.WriteLine("Enter the number of siblings you have: ");
        string numSibling = Console.ReadLine();
        //Output
        Console.WriteLine("I also have " + numSibling + " siblings");
        //break sec
        Console.WriteLine("\n\n\nPress any key to continue...\n");
        Console.ReadKey();

    }
}