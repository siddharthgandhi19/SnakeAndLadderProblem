using System;
namespace SnakeAndLadderProblem
{
    public class GamePlay
    {
        public void Position()
        {
            int playerPosition = 0;
            Console.WriteLine("Lets Play!!!");
            Console.WriteLine("You are at " + playerPosition);
            Console.WriteLine("Lets Roll");
        }

        public void DiceRoll()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("Output of Dice - " + dice);
        }

    }
}