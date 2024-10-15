namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNum = 13;

            Console.WriteLine("Guess my favorite number:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput > favNum)
            {
                Console.WriteLine("Too high");
                
            }
            else if (userInput < favNum)
            {
                Console.WriteLine("Too low");
            }
            else 
            { 
                Console.WriteLine("You guessed it!!");
            }

        }
    }
}
