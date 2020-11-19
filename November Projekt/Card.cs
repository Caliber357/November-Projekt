using System;
using System.Collections.Generic;


namespace November_Projekt
{
    public class Card
    {
        private Random rng = new Random();
        private bool lost = false;

        public Card(int n)
        {
            name = n;

        }
        private void WhatCard(){
            switch(name){
                case 1:

                break;
            }
            
        }
        private int name = 0;
        public int GetName(){
            return name;
        }

        public bool isOver21()
        {


            return lost;
        }


    }
}
