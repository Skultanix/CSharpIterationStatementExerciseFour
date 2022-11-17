namespace IterationStatementExerciseFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a guessing game. You have four attempts to guess a number between one and ten.");
            Random theNumberToGuess = new Random();
            var target = theNumberToGuess.Next(10);
            Console.WriteLine(target);
            var guessAttempts = 4;

            for (int i = 1; i < 5; i++)
            {
                var userGuess = Console.ReadLine();
                int userGuessVal = int.Parse(userGuess);

                if (userGuessVal == target)
                {
                    Console.WriteLine(string.Format(@"Congratulations! You guessed ""{0}"" correctly, in {1} attempts.", target, i));
                } else if(userGuessVal != target)
                {
                    guessAttempts--;
                    Console.WriteLine(string.Format("That was incorrect. You have {0} attempts left.", guessAttempts));
                } else
                {
                    Console.WriteLine("You ran out of attempts.");
                }
            }
        }
    }
}