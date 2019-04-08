using System;
using System.Collections.Generic;

namespace hackathon{
    public class Picture{
        public bool won = false;
        string[] boards;
        public Picture(){
            boards = new string[8];
            boards[0] = "     _________ \n     |/      | \n     |       \n     |       \n     |        \n     |      \n     | \n ____|_________________";
            boards[1] = "     _________ \n     |/      | \n     |      (_)       \n     |       \n     |        \n     |      \n     | \n ____|_________________";
            boards[2] = "     _________ \n     |/      | \n     |      (_)       \n     |       | \n     |       | \n     |       \n     | \n ____|_________________";
            boards[3] = "     _________ \n     |/      | \n     |      (_)       \n     |      /| \n     |       | \n     |       \n     | \n ____|_________________";
            boards[4] = "     _________ \n     |/      | \n     |      (_)       \n     |      /|\\ \n     |       | \n     |       \n     | \n ____|_________________";
            boards[5] = "     _________ \n     |/      | \n     |      (_)       \n     |      /|\\ \n     |       | \n     |      /  \n     | \n ____|_________________";
            boards[6] = "     _________ \n     |/      | \n     |      (_)       \n     |      /|\\ \n     |       | \n     |      / \\  \n     | \n ____|_________________";
            boards[7] = " ___________.._______\n| .__________))______|\n| | / /      ||\n| |/ /       ||\n| | /        ||.-''.\n| |/         |/  _  \\ \n| |          ||  `/,|\n| |          (\\\\`_.'\n| |         .-`--'.\n| |        /Y . . Y\\ \n| |       // |   | \\\\ \n| |      //  | . |  \\\\ \n| |     ')   | _ |   (`\n| |          || ||\n| |          || ||\n| |          || ||\n| |          || ||\n| |         / | | \\ \n__________|_`-' `-' |___|\n|=|=======\\ \\       '=|=|\n| |        \\ \\        | |\n: :         \\ \\       : :\n. .          `'       . .";
            // string ending = " ___________.._______\n| .__________))______|\n| | / /      ||\n| |/ /       ||\n| | /        ||.-''.\n| |/         |/  _  \\ \n| |          ||  `/,|\n| |          (\\\\`_.'\n| |         .-`--'.\n| |        /Y . . Y\\ \n| |       // |   | \\\\ \n| |      //  | . |  \\\\ \n| |     ')   |   |   (`\n| |          || ||\n| |          || ||\n| |          || ||\n| |          || ||\n| |         / | | \\ \n__________|_`-' `-' |___|\n|=|=======\\ \\       '=|=|\n| |        \\ \\        | |\n: :         \\ \\       : :\n. .          `'       . .";
            
            
        }
        public void BoardId(int idx){
            System.Console.WriteLine(boards[idx]);
        }

        public void BoardId(){
            System.Console.WriteLine(boards[0]);
        }
        public void HiddenWord(string word){
            string displayString = "";
            for( int i =0; i <word.Length;i++){
                if(word[i].ToString() != " "){
                    displayString += "_";
                }
                else{
                    displayString += " ";
                }

            }
            if (!displayString.Contains("_")){
                System.Console.WriteLine("You Win a Beer!");
            }else{
                System.Console.WriteLine(displayString);
                // System.Console.WriteLine("Display String Worked");
            }
        }
        public void HiddenWord(string word, List<char> LettersGuessed){
            string displayString = "";
            List<char> tempGuessed = LettersGuessed;
            bool stuff = false;
            
                    
            for( int i =0; i <word.Length;i++){
                for(int j = 0; j<LettersGuessed.Count;j++){
                    if(word[i] == tempGuessed[j]){
                        displayString += LettersGuessed[j];
                        stuff = false;
                        break;
                        // System.Console.WriteLine($"letters Guessed {LettersGuessed[j] }") ;
                    }else if(word[i].ToString() == " "){
                        displayString += " ";
                        stuff = false;
                        // System.Console.WriteLine(" ");
                    }else{
                        stuff = true;
                        // tempGuessed.RemoveAt(j);
                   }
                }
                   if(stuff){

                        displayString += "_";
                        stuff = false;
                   }
                    // System.Console.WriteLine("FIRST: {0}",displayString);s
                    
            }
            if (!displayString.Contains("_")){
                System.Console.WriteLine("You Win a Beer!");
                won = true;
            }else{
                System.Console.WriteLine(displayString);
                // System.Console.WriteLine("Display String Worked");

            }

        }

    }
}