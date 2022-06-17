using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turns : MonoBehaviour

// add a common click event to each button
for(int i = 0; < button.Length; i++)
{
buttons[i].Click += handleButtonclick;
buttons[i].Tag = i;
}

}

private void handleButtonclick(object sender, EventArgs e){

Button clickedButton = (Button) sender;
// MessageBox.Show ("button  " + clickedButton.Tag + "  was clicked");

int gameSquareNumber = (int)clickedButton.Tag;

game.Grid[gameSquareNumber] = 1;

updateBoard();

if (gameisBoardFull() == true)
MessageBox.show("The board is full");
disableAllButtons();
}

else if (game.checkForWinner() ==1)
{
MessageBox.Show("Player human wins!");
disableAllButtons();

}
else
{
// computer's turn
computerChoose();
}

}

private void disableAllButtons()
{
foreach (var item in buttons)
{
item.Enabled = false;
}

}
private void computerChoose()
{

// computer picks a random number. Update game.Grid to reflect the choice.
// get a random number from computer

while(computerTurn == -1 || game.Grid[computerTurn] != 0)
{

computerTurn = rand.Next(9);
Console.WriteLine ("Computer chooses  " + computerTurn);

}
game.Grid[computerTurn] = 2;
updateBoard();

// check for winner
// check to see if the board is full

if (gameisBoardFull() == true)
{
MessageBox.show("The board is full");
disableAllButtons();
}

else if (game.checkForWinner() == 2)
{
MessageBox.Show("Player computer wins!");
disableAllButtons();

}

}

//form method 
private void Form1_Load(object sender, EventArgs e)
{
updateBoard();
}

private void updateBoard()
{
// assign an X or O to the test of each button based on the values in the Board\
for (int i = 0; i < game.Grid.Length; i++)
{
if (game.Grid[i] == 0)
{
buttons[i].Text = "";
buttons[i].Enabled = true;
}
else if (game.Grid[i] == 1)
{
buttons[i].Text = "X";
buttons[i].Enabled = false;
}
else if(game.Grid[i] ==2)
{
buttons[i].Text = "O";
buttons[i].Enabled = false;
}

}

}
}
