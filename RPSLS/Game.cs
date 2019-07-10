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
                player1 = new Human("Murphy");
                player2 = new Computer("Wilson");
            }
            else
            {
                player1 = new Human("Karen");
                player2 = new Human("Dan");
            }
        }
        public void RunGame()
        {
            Console.WriteLine("Welcome to RPSLS! Rules are same as a typical RPS with 2 extra gestures to choose from. Best 2 out of 3 games wins.");
            string input = Console.ReadLine();

            
        }

        public void CompareGestures()
        {
            
            string player1gesture = player1.ChooseGesture();
           
            
            string player2gesture = player2.ChooseGesture();
            if (player1gesture == "Rock")
            {
                if (player2gesture == "Paper")
                    Console.WriteLine("Paper covers Rock");
                player2.score++;
                if (player2gesture == "Scissors")
                    Console.WriteLine("Rock smashes Scissors");
                player1.score++;
                if (player2gesture == "Spock")
                    Console.WriteLine("Spock vaporizes Rock");
                player2.score++;
                if (player2gesture == "Lizard")
                    Console.WriteLine("Rock crushes Lizard");
                player1.score++;
                if (player2gesture == "Rock")
                    Console.WriteLine("It's a tie!");
                

                if (player1gesture == "Paper")
                {
                    if (player2gesture == "Scissors")
                        Console.WriteLine("Scissors cuts Paper");
                    player2.score++;
                    if (player2gesture == "Spock")
                        Console.WriteLine("Paper disproves Spock");
                    player1.score++;
                    if (player2gesture == "Lizard")
                        Console.WriteLine("Lizard eats Paper");
                    player2.score++;
                    if (player2gesture == "Rock")
                        Console.WriteLine("Paper covers Rock");
                    player1.score++;
                    if (player2gesture == "Paper")
                        Console.WriteLine("It's a tie!");


                if (player1gesture == "Scissors")
                {
                    if (player2gesture == "Lizard")
                        Console.WriteLine("Scissors decapitates Lizard");
                        player1.score++;
                    if (player2gesture == "Spock")
                            Console.WriteLine("Spock smashes scissors");
                        player2.score++;
                    if (player2gesture == "Rock") 
                        Console.WriteLine("Rock crushes scissors");
                        player2.score++;
                    if (player2gesture == "Paper")
                            Console.WriteLine("Scissors cuts Paper");
                        player1.score++;
                    if (player2gesture == "Scissors")
                            Console.WriteLine("It's a tie!");
                    
                }
                if (player1gesture == "Lizard")
                {
                    if (player2gesture == "Spock")
                        Console.WriteLine("Lizard poisons Spock");
                        player1.score++;
                    if (player2gesture == "Scissors")
                        Console.WriteLine("Scissors decapitates Lizard");
                    player2.score++;
                    if (player2gesture == "Spock")
                        Console.WriteLine("Lizard poisons Spock");
                    player2.score++;
                    if (player2gesture == "Rock")
                        Console.WriteLine("Rock crushes Lizard");
                    player2.score++;
                    if (player2gesture == "Paper")
                        Console.WriteLine("Lizard eats Paper");
                    player1.score++;
                    if (player2gesture == "Lizard")
                        Console.WriteLine("It's a tie!");

                    }
                if (player1gesture == "Spock")
                {
                    if (player2gesture == "Rock")
                        Console.WriteLine("Spock vaporizes Rock");
                    player1.score++;
                    if (player2gesture == "Lizard")
                        Console.WriteLine("Lizard poisons Spock");
                    player2.score++;
                    if (player2gesture == "Scissors")
                        Console.WriteLine("Spock smashes Scissors");
                    player1.score++;
                    if (player2gesture == "Rock")
                        Console.WriteLine("Spock vaporizes Rock");
                    player1.score++;
                    if (player2gesture == "Paper")
                        Console.WriteLine("Paper disproves Spock");
                    player2.score++;
                    if (player2gesture == "Spock")
                        Console.WriteLine("It's a tie!");


                }
            }
            Console.WriteLine();
             
        }

        public void CheckWinner()
        {

            
                (int i = 0; i < score.Length; i++)
                Console.WriteLine("Your new score is  ")

        }

        public void RunGame()
        {
            int 
            while ()
            {
            
            }
        }





    }
}
