using System;

public class GuessGane
{

    static String secreatWord = "kishore";
    static String userGuess = "";
    
    public static void GuessGameT()
    {
        int guessCount = 0;
        int guessLimit = 3;
        bool outOfGuesses = false;

		while (userGuess != secreatWord && !outOfGuesses)
		{
			if (guessCount < guessLimit)
			{
				Console.WriteLine("Guess a Word");
				userGuess = Console.ReadLine();
				guessCount++;
			}
			else
			{
				outOfGuesses = true;
			}
		}

		if (outOfGuesses)
		{
			Console.WriteLine("oops you lost the game");
		}
		else
		{
			Console.WriteLine("yaay you won the game");
		}
    }
}