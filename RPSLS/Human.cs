using System;
namespace RPSLS
{
    public class Human : Player
    {
        public string player1;


        public Human(string name)
            : base(name)
        {
            
            score = 0;
          
        }


        public override void ChooseGesture()
        {
            Console.WriteLine("Choose a gesture: rock, paper, scissors, lizard, spock");
            string input = Console.ReadLine();

            switch (input)
            {
                case "Rock":
                    Console.WriteLine("Rock");
                    break;
                case "Paper":
                    Console.WriteLine("Paper");
                        break;
                case "Scissors":
                    Console.WriteLine("Scissors");
                    break;
                case "Lizard":
                    Console.WriteLine("Lizard");
                    break;
                case "Spock":
                    Console.WriteLine("Spock");
                    break;
                default:
                    Console.WriteLine("Not a valid gesture");
                    break;

            } 
        

           
        }
    }
}


