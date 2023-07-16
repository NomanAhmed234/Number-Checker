namespace Lab_2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The program that checks that either the user input number is EVEN, ODD or ZERO.
            Console.WriteLine("Enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number  == 0)
            {
                Console.WriteLine("The number is Zero.");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("The number is Even.");
            }
            else  
            {
                Console.WriteLine("The number is Odd.");
            }
             
        }
    }
}