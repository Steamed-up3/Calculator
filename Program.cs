internal class Program
{
    private static void Main(string[] args)
    {
        // This is a calculator that can only do multiplication. 
        string symbol;
        double num1;
        double num2;
        double ans = 0;

        Console.WriteLine("When you are finshed using this utility, press Ctrl + C to exit.");
        Console.WriteLine("You can also leave the operation field blank.\n");

        while (true)
        {
            Console.Write("Please enter a number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("What operation would you like to do? (+, -, /, *): ");
            symbol = Console.ReadLine();

            Console.Write("Please enter a second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (symbol == "+")
            {
                ans = num1 + num2;
            }
            else if (symbol == "-")
            {
                ans = num1 - num2;
            }
            else if (symbol == "/")
            {
                ans = num1 / num2;
            }
            else if (symbol == "*")
            {
                ans = num1 * num2;
            }
            else
            {
                break;
            }
            Console.WriteLine("The answer is " + ans + ".\n");
        }
            
        // This is to wait for the user to input something to exit.
        // Console.ReadKey();
    }
}