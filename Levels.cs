using System;
using System.Collections.Generic;

namespace hackathon
{

    public class Easy : Hangman{
        List<string> easyWords;
        public Easy() {
            boardLvl = 0;
            Random rand = new Random();
            easyWords = new List<string>();
            easyWords.Add("heart");
            easyWords.Add("jazz");
            easyWords.Add("rocket");
            easyWords.Add("star");
            easyWords.Add("white");
            easyWords.Add("ice cream");
            easyWords.Add("attack");
            easyWords.Add("floss");
            easyWords.Add("honda");
            easyWords.Add("fart");
            CurrentWord = easyWords[rand.Next(0,9)];
            board.HiddenWord(CurrentWord);
            
            // System.Console.WriteLine(CurrentWord);
            //have a function that displays the correct amount of __________ ____ _____
            // generateBoard();
        }
        
       
    }
    public class Medium : Hangman {
        public List<string> medWords;
        
        public Medium() {
            boardLvl = 0;
            Random rand = new Random();
            medWords = new List<string>();
            medWords.Add("clear as mud");
            medWords.Add("dont mess with texas");
            medWords.Add("eye candy");
            medWords.Add("flip the switch");
            medWords.Add("give me a break");
            medWords.Add("head over heels");
            medWords.Add("just like clockwork");
            medWords.Add("like two peas in a pod");
            medWords.Add("live and learn");
            medWords.Add("pinch me i must be dreaming");
            CurrentWord = medWords[rand.Next(0,9)];            
            System.Console.WriteLine(CurrentWord);
            board.HiddenWord(CurrentWord);

            //have a function that displays the correct amount of __________ ____ _____
            // generateBoard();
        }
    }
    public class Hard : Hangman{
        List<string> hardWords;
        public Hard() {
            boardLvl = 0;
            Random rand = new Random();
            hardWords = new List<string>();
            hardWords.Add("wildebeest"); 
            hardWords.Add("zombie");
            hardWords.Add("zealous");
            hardWords.Add("memento");
            hardWords.Add("haphazard");
            hardWords.Add("gazebo");
            hardWords.Add("dwarves");
            hardWords.Add("bagpipes");
            hardWords.Add("bungler");
            hardWords.Add("croquet");
            CurrentWord = hardWords[rand.Next(0,9)];
            System.Console.WriteLine(CurrentWord);
            
            //have a function that displays the correct amount of __________ ____ _____
            // generateBoard();
        }
    }
}