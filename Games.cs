using System;
using System.Collections.Generic;

namespace hackathon{
    public abstract class Hangman{
        public Picture board;
        public int score;
        public int boardLvl;
        public string CurrentWord;
        public int guessesLeft;
        
        public string displayWord;
        List<char> lettersGuessed= new List<char>();

        public Hangman(){
            
            guessesLeft = 7;
            //creates a board class object
            board = new Picture();
            //calls the method inside of the object, this will console.writeline the starting board. 
            //You can put a index paramater in the argument to get the progress 0-7
            board.BoardId();
            //have a function that displays the correct amount of __________ ____ _____
            // generateBoard();
            score = 0;
            
        }
        public void playersGuess(char guess){

            // string guess = Console.Readline();
            // if(guess.Contains(phrase)){
            //     correct();
            // }
            // else{
            //     wrong();
            // }
            Console.WriteLine($"You guess {guess}");
            if(CurrentWord.Contains(guess.ToString())){
                Console.WriteLine("CORRECT!");
                lettersGuessed.Add(guess);
                correct();
            }
            else{
                Console.WriteLine("Wrong!");

                wrong();
                
            }
            
        }
        public void correct(){
            //FIGURE OUT HOW TO ADD THE CORRECT LETTER TO THE BOARD
            //CHECK IF ALL LETTERS ARE FOUND AND GENERATES A MEDIUM BOARD/ RESETS GUESSES
            //ADD TO THE SCORE IF SOLVED
            // refreshes the board with the same information
            board.BoardId(boardLvl);
            // updates the correct letters on the ___ _h__ ___s
            board.HiddenWord(CurrentWord, lettersGuessed);
            if(board.won ==true){
                guessesLeft = 0;
            }

        }
        public void wrong(){
            // //CALL THE NEW BOARD WITH AN ADDITIONAL BODY PART
            // guessesLeft--;
            // if(guessesLeft ==0){
            //     //GENERATE THE FINAL BOARD
            //     Console.WriteLine("You lost");
            // }
                 //CALL THE NEW BOARD WITH AN ADDITIONAL BODY PART
            guessesLeft--;
            // refreshes the board with the the next part added on
            board.BoardId(++boardLvl);
            // refreshes the sentence to what was displayed earlier
            board.HiddenWord(CurrentWord);
            if(guessesLeft ==0){
                //GENERATE THE FINAL BOARD
                board.BoardId(7);
                // Console.WriteLine("You lost");
            }
        }
        }

    }

