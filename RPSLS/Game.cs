using System;
namespace RPSLS
{
    public class Game
       
    {
        // member variables
        public Player player1;
        public Player player2;

                   
        public void ChooseGameMode()
        {
            Console.WriteLine("Is this single player or multiplayer");
            string input = Console.ReadLine();
            if(input == "single player")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else
            {
                player1 = new Human();
                player2 = new Human();
            }
        }
        public void RunGame()
        {
            Console.WriteLine("Welcome to RPSLS! Rules are same as a typical RPS with 2 extra gestures to choose from. Best 2 out of 3 games wins.");
            string  = Console.ReadLine();

            
        }
        
        public void CompareGestures()
        {
            Console.WriteLine()

               

        }

        public void CheckWinner()
        {

            score = new score
                for (int i = 0; i < score.Length; i++)
                Console.WriteLine("Your new score is  ")

        }







    }
}
