using System;
using System.Collections.Generic;


namespace November_Projekt
{
    public class Card
    {
        private Random rng = new Random();
        private bool lost = false;

        private bool ace = false;
        public Card(int n)
        {
            name = n;

        }
        public int cardValue;
        public void Hit()
        {
            WhatCard();
        }
        private void WhatCard()
        {
            if (name == 1 || name == 14 || name == 27 || name == 40)
            {
                while (ace == false)
                {
                    System.Console.WriteLine("You got an ace would you like it to be worth 1 or 11?");
                    string answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        cardValue = 1;
                        ace = true;
                        System.Console.WriteLine("You decided to make the ace worth 1");
                        Console.ReadLine();
                    }
                    else if (answer == "11")
                    {
                        cardValue = 11;
                        ace = true;
                        System.Console.WriteLine("You decided to make the ace worth 11");
                        Console.ReadLine();
                    }
                    else
                    {
                        System.Console.WriteLine("That was an in valid answer. Valid answers are 1 or 11.");
                    }
                }

            }
            if (name == 2 || name == 15 || name == 28 || name == 41)
            {
                cardValue = 2;
                System.Console.WriteLine("You got a " + cardValue);
                Console.ReadLine();
            }
            if (name == 3 || name == 16 || name == 29 || name == 42)
            {
                cardValue = 3;
                System.Console.WriteLine("You got a " + cardValue);
                Console.ReadLine();
            }
            if (name == 4 || name == 17 || name == 30 || name == 43)
            {
                cardValue = 4;
                System.Console.WriteLine("You got a " + cardValue);
                Console.ReadLine();
            }
            if (name == 5 || name == 18 || name == 31 || name == 44)
            {
                cardValue = 5;
                System.Console.WriteLine("You got a " + cardValue);
                Console.ReadLine();
            }
            if (name == 6 || name == 19 || name == 32 || name == 45)
            {
                cardValue = 6;
                System.Console.WriteLine("You got a " + cardValue);
                Console.ReadLine();
            }
            if (name == 7 || name == 20 || name == 33 || name == 46)
            {
                cardValue = 7;
                System.Console.WriteLine("You got a " + cardValue);
                Console.ReadLine();
            }
            if (name == 8 || name == 21 || name == 34 || name == 47)
            {
                cardValue = 8;
                System.Console.WriteLine("You got a " + cardValue);
                Console.ReadLine();
            }
            if (name == 9 || name == 22 || name == 35 || name == 48)
            {
                cardValue = 9;
                System.Console.WriteLine("You got a " + cardValue);
                Console.ReadLine();
            }
            if (name == 10 || name == 23 || name == 36 || name == 49)
            {
                cardValue = 10;
                System.Console.WriteLine("You got a " + cardValue);
                Console.ReadLine();
            }
            if (name == 11 || name == 24 || name == 37 || name == 50)
            {
                cardValue = 10;
                System.Console.WriteLine("You got a Jack");
                Console.ReadLine();
            }
            if (name == 12 || name == 25 || name == 38 || name == 51)
            {
                cardValue = 10;
                System.Console.WriteLine("You got a Queen");
                Console.ReadLine();
            }
            if (name == 13 || name == 26 || name == 39 || name == 52)
            {
                cardValue = 10;
                System.Console.WriteLine("You got a King");
                Console.ReadLine();
            }

        }
        private int name = 0;
        public int GetName()
        {
            return name;
        }

        public bool isOver21()
        {


            return lost;
        }


    }
}
