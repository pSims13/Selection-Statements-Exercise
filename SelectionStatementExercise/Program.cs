namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1

            int favNumber = 29;
            int userInput = 0;

            while (userInput != favNumber)
            {
                Console.WriteLine("Try to guess my favorite number between 1-100.");
                userInput = int.Parse(Console.ReadLine());


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


            //Exercise 2

            Console.WriteLine("What is your favorite subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("You have to be really smart if you like Math");
                    break;
                case "science":
                    Console.WriteLine("I think Science is awesome!");
                    break;
                case "history":
                    Console.WriteLine("If you dont know your History your bound to repeat it!");
                    break;
                case "art":
                    Console.WriteLine("Thats awesome! I've never been great at drawing.");
                    break;
                case "music":
                    Console.WriteLine("I've always wanted to learn the piano.");
                    break;
                default:
                    Console.WriteLine("Neat. Tell me why!");
                    Console.ReadLine();
                    Console.WriteLine("Thanks for sharing.");
                    break;
            }
        }
    }
}