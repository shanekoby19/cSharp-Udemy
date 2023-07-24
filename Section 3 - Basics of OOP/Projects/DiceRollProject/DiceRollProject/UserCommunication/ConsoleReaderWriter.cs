namespace DiceRollProject.UserCommunication;

public static class GameReaderWriter
{
	public static int getInput()
	{
		bool isValidResponse = false;
		int number = 0;

		while(!isValidResponse)
		{
            Console.WriteLine("Please guess a number between 1 and 6: ");
			isValidResponse = int.TryParse(Console.ReadLine(), out number);
        }

		return number;
	}

	public static void printWinningMessage(int winningNumber)
	{
        Console.WriteLine($"Congradulations, {winningNumber} was the correct number!");
    }

    public static void printLosingMessage()
    {
        Console.WriteLine("You lost, better luck next time.");
    }

	public static void printTryAgain(int guess, int attemptsLeft)
	{
		Console.WriteLine($"Sorry, {guess} is not the correct answer. You have {attemptsLeft} attempts left.");
	}
}


