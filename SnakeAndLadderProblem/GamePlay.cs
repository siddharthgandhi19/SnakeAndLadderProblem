using System;
namespace SnakeAndLadderProblem
{
    public class GamePlay
    {
        Random random = new Random();
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int playerPosition = 0;

        public void Position()
        {
            Console.WriteLine("Lets Play!!!" + "\t" + "You are at - " + playerPosition);
        }
        public int DiceRoll()
        {
            int dice = random.Next(1, 7);
            Console.WriteLine("Output of Dice - " + dice);
            Console.WriteLine("You are at -", _ = this.playerPosition);
            return dice;
        }
        public void Check()
        {
            while (playerPosition < WINNING_POSITION)
            {
                int ROLL = random.Next(0, 3);
                Console.WriteLine(ROLL);
                switch (ROLL)
                {
                    case NO_PLAY:
                        this.playerPosition += 0;
                        break;
                    case LADDER:
                        this.playerPosition += DiceRoll();
                        break;
                    case SNAKE:
                        this.playerPosition -= DiceRoll();
                        break;
                }
                Console.WriteLine(this.playerPosition);
            }
        }
    }
}