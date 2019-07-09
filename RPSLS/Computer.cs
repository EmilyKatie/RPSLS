using System;

namespace RPSLS
{
    public class Computer : Player
    {
        public string player2;

        public Computer(string name, int score, string gesture) : base(name)
        {

            this.gesture = gesture;
            this.score = score;
            Console.WriteLine("Choose gesture");
        }

        public override void ChooseGesture()
        {
            Random numbergenerator = new Random();

            int num1 = numbergenerator.Next(1, 6);


            Console.WriteLine("1 = Rock, 2 = Paper, 3 = Scissors, 4 = Lizard, 5 = Spock");
            {
            if (num1 == 1)

                Console.WriteLine("Rock");

            else

                Console.WriteLine("");

            if (num1 == 2)

                Console.WriteLine("Paper");
            else

               Console.WriteLine("");

            if (num1 == 3)

                Console.WriteLine("Scissors");
            else

                Console.WriteLine("");
            if (num1 == 4)


                Console.WriteLine("Lizard");
            else
                Console.WriteLine("");
            if (num1 == 5)
                Console.WriteLine("Spock");
            else
                Console.WriteLine("");

            }  

               



        }
        

    }
}