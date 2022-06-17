using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CheckForWinner : MonoBehaviour
{
    Board game = new Board();
    Random rand = new Random();

    public CheckForWinner()
    {
    }

    private void handleButtonclick(object sender, EventArgs e){

        Button clickedButton = (Button) sender;
// MessageBox.Show ("button  " + clickedButton.Tag + "  was clicked");

      //  int gameSquareNumber = (int)clickedButton.Tag;

     //   game.Grid[gameSquareNumber] = 1;

        updateBoard();

      //  if (gameisBoardFull() == true) 
        {
          //  MessageBox.show("The board is full");
            disableAllButtons();
        }

     //   else if (game.checkForWinner() ==1)
        {
           // MessageBox.Show("Player human wins!");
            disableAllButtons();

        }
    //    else
        {
// computer's turn
            computerChoose();
        }



    }

    private void updateBoard()
    {
        throw new NotImplementedException();
    }

    private void disableAllButtons()
    { 
     // foreach (var item in TicTacToeAI)
        {
     //       item.Enabled = false;
        }

    }


    private void computerChoose()
    {

// computer picks a random number. Update game.Grid to reflect the choice.
// get a random number from computer

      //  while(computerTurn == -1 || game.Grid[computerTurn] != 0)
        {

         //   computerTurn = rand.Next(9);
         //   Console.WriteLine ("Computer chooses  " + computerTurn);

        }
      //  game.Grid[computerTurn] = 2;
        updateBoard();

// check for winner
// check to see if the board is full

      //  if (gameisBoardFull() == true)
        {
      //      MessageBox.show("The board is full");
            disableAllButtons();
        }

      //  else if (game.checkForWinner() == 2)
        {
     //       MessageBox.Show("Player computer wins!");
            disableAllButtons();

        }

    }
}
