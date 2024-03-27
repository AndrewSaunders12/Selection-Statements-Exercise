using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int favNumber = r.Next(1, 1000);
            Console.WriteLine("Guess my favorite number between 1 in 1000:");
            var userInput = int.Parse(Console.ReadLine());

            
            if(favNumber > userInput)
            {
                Console.WriteLine("Too Low");
            }
            else if(favNumber < userInput)
            {
                Console.WriteLine("Too High");
            }
            else 
            {
                Console.WriteLine("You guessed it!!!");
            }
        }
    }
}
