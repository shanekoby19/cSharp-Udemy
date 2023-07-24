using DiceRollProject.UserCommunication;

public class DiceRollGame
{
    private DiceRoll _diceRoll = new DiceRoll();
    private bool _gameWon = false;
    private int _attemptsLeft = 3;

    private bool isValidGuess(int guess) => guess == _diceRoll._die;

    private void attemptGuess(int guess)
    {
        if (isValidGuess(guess))
        {
            _gameWon = true;
        }
        else
        {
            _attemptsLeft--;
            GameReaderWriter.printTryAgain(guess, _attemptsLeft);
        }
    }

    public void play()
    {
        while (!_gameWon && _attemptsLeft > 0)
        {
            int guess = GameReaderWriter.getInput();

            attemptGuess(guess);
        }

        if(_gameWon)
        {
            GameReaderWriter.printWinningMessage(_diceRoll._die);
        } else
        {
            GameReaderWriter.printLosingMessage();
        }
    }
}


