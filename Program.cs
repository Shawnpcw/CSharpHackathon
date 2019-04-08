using System;
using System.Collections.Generic;

namespace hackathon
{
    class Program
    {
        static void Main(string[] args)
        {

            Easy game1 = new Easy();
            
            while(game1.guessesLeft>0){
                string a = Console.ReadLine().ToString();
                game1.playersGuess(a[0]);
                

            }
        }
    }
}
