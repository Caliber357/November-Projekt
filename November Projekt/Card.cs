using System;
using System.Collections.Generic;


namespace November_Projekt
{
    public class Card
    {
        private Random rng = new Random();
        private int cardValue = 0;
        private bool lost = false;
        //private string[] card = {"Ace", "2"}


        public void whatCard(){
            int v = rng.Next(1,11);
            cardValue = v;
            if (cardValue == 1 || cardValue == 11){
                System.Console.WriteLine("Do you your ace to be worth 1 or 11");
                string answer = Console.ReadLine();
                switch(answer){
                    case "1":
                    cardValue = 1;
                    break;
                    case "11":
                    cardValue = 11;
                    break;
                    default:
                    System.Console.WriteLine("That was not a valid answer");
                    break;
                }
            }
            System.Console.WriteLine("The value of your card is");
        }
        public bool isOver21(){
            
            
            return lost;
        }


    }
}
