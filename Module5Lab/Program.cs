using System;

namespace Module5Lab
{
    internal class Player
    {
        private string name;
        private int score;
        private int livesLeft;

        public Player()
        {
        }

        public Player(string name)
        {
            this.name = name;
        }

        public Player(string name, int startingLives)
        {
            this.name = name;
            livesLeft = startingLives;
        }

        public int GetScore()
        {
            return score;
        }

        public void AddPoints(int totalPoints)
        {
            score += totalPoints;
        }

        public void Kill()
        {
            // We make sure they can't get negative lives.
            if (livesLeft > 0)
            {
                livesLeft--;
            }
        }

        public int GetLivesLeft()
        {
            return livesLeft;
        }
    }

    internal class SuperPlayer : Player
    {
        public SuperPlayer(string name, int startingLives) : base(name, startingLives)
        {
        }

        public void Fly()
        {
            Console.WriteLine("SuperPlayer is flying!");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create a new player with one life and add points to the player's score
            Player player = new Player("Frankenstein", 1);
            player.AddPoints(100);

            // Display the player's score
            Console.WriteLine("Welcome to the game! Your score is: " + player.GetScore() +
                " You have " + player.GetLivesLeft() + " lives left!");

            // Kill off the player's character
            player.Kill();

            // Let the player know their character was killed
            Console.WriteLine("An orc attacks you. Sorry, you were killed. You have "
                + player.GetLivesLeft() + " lives left!");

            // Create a super player
            SuperPlayer superPlayer = new SuperPlayer("Superman", 3);
            superPlayer.AddPoints(200);
            superPlayer.Fly(); // Demonstrate the additional ability

            Console.WriteLine($"SuperPlayer score: {superPlayer.GetScore()}, Lives left: {superPlayer.GetLivesLeft()}");
        }
    }
}
