using DiceRollGame.Game;
var guessingGame = new GuessingGame(new Dice(new Random()));
GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);
