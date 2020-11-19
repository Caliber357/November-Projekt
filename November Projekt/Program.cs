using System;
using System.Collections.Generic;

namespace November_Projekt
{
    class Program
    { 
        static void Main(string[] args)
        {
        List<Card> Cards = new List<Card>();
            for (int i = 1; i < 53; i++)
            {
                Cards.Add(new Card(i));
            }
            for (int i = 0; i < Cards.Count; i++)
            {
                System.Console.WriteLine(Cards[i].GetName());
            }
            Console.ReadLine();
        }
    }
}
