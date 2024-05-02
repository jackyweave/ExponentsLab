using System; 
class Program
{
    static void Main()
    {
        string choice;
        do
        {
            Console.WriteLine("Enter a number to display its powers: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number\t\tSquared\t\tCubed");
            Console.WriteLine("------\t\t-------\t\t-----");


            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}\t\t{Math.Pow(i, 2)}\t\t{Math.Pow(i, 3)}");
            }


            Console.Write("Do you want to go again? (yes/no): ");
            choice = Console.ReadLine();

        } while (choice.ToLower() == "yes"); 
    }
}