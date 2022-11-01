using System;
namespace SnakeAndLadderProblem

{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem Statement");

            GamePlay playerPosition = new GamePlay();
            playerPosition.Position();
            GamePlay check = new GamePlay();
            check.Check();
            GamePlay dice = new GamePlay();
            dice.DiceRoll();

        }
    }
}