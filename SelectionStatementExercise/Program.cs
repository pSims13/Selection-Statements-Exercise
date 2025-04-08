namespace SelectionStatementExercise
{
    public class Program
    {

        static void Main(string[] args)
        {
            int favNumber = 29;

            Console.WriteLine("Try to guess my favorite number between 1-100.");
            
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low, try again.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high, try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the number.");
            }



        }
    }
}
