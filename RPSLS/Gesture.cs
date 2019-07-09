using System;
namespace RPSLS
{
    public class ChooseGesture
    {
        public string gesture;
        
        public ChooseGesture(string gesture)
        {
            this.gesture = gesture;
            
        }

        public void Choose()
        {
            List<string> gesture = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
                int index = random.Next(gesture.Count);
           gesture[index];
            gesture.RemoveAt(index);
            return gesture;
        }
            

        //foreach (string gesture in collection) 



//Gestures.Add("Rock crushes Scissors");
//Gestures.Add("Scissors cuts Paper");
//Gestures.Add("Paper covers Rock");
//Gestures.Add("Rock crushes Lizard");
//Gestures.Add("Lizard poisons Spock");
//Gestures.Add("Spock smashes Scissors");
//Gestures.Add("Scissors decapitates Lizard");
//Gestures.Add("Lizard eats Paper");
//Gestures.Add("Paper disproves Spock");
//Gestures.Add("Spock vaporizes Rock");

//gesture.Add("Rock");
//gesture.Add("Paper");
//gesture.Add("Scissors");
//gesture.Add("Lizard");
//gesture.Add("Spock");
//gesture.Remove("Rock");
//gesture.
//gesture.Remove("Paper");
//gesture.Remove