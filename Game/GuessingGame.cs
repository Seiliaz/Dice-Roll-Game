namespace DiceRollGame.Game;
using DiceRollGame.UserCommunication;

public class GuessingGame
{
    private readonly Dice _dice;
    private const int initialTries = 3;
    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }
    public GameResult Play()
    {
        int diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {initialTries} tries");
        int triesLeft = initialTries;
        while (triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter a number: ");
            if (guess == diceRollResult) return GameResult.Victory;
            Console.WriteLine("Wrong number.");
            --triesLeft;
        }
        return GameResult.Loss;
    }
    public static void PrintResult(GameResult result)
    {
        string message = result == GameResult.Victory
            ? "You win :)"
            : "You lose :(";
        Console.WriteLine(message);
    }
}
