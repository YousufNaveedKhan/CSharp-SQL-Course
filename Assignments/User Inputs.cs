class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter their name
        Console.WriteLine("Enter your name");

        // Read the input provided by the user and store it in a string variable called userName
        string userName = Console.ReadLine();
        
        // Print a welcome message using the userName variable
        Console.WriteLine("Welcome, " + userName + "!");

        // Declare variables of different data types
        long Long= 7896541230L;
        short Short= -15;
        float Float= 24.5f;

        // Print the value of each variable
        Console.WriteLine("Value of long variable: " + Long);
        Console.WriteLine("Value of short variable: " + Short);
        Console.WriteLine("Value of float variable: " + Float);
    }
}

