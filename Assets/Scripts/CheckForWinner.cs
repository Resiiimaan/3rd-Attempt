using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using TMPro;
using static TicTacToeAI;        

public class CheckForWinner : MonoBehaviour
{
    public TicTacToeState playerState;
    public TicTacToeState aiState;

    public class Board
    {
        public int[] cube;
        
        public void EndTurn()
        { // return a 0 if nobody won. return the player number if they won.
           //top row.
            if (cube[0] == (int) TicTacToeState.cross && cube[1] == (int) TicTacToeState.cross && cube[2] == (int) TicTacToeState.cross)
            {
                GameOver();
            }
            //Middle row.
            if (cube[3] == (int) TicTacToeState.cross && cube[4] == (int) TicTacToeState.cross && cube[5] == (int) TicTacToeState.cross)
            {
            }

            //Bottom row.
                if (cube[6] == (int) TicTacToeState.cross && cube[7] == (int) TicTacToeState.cross && cube[8] == (int) TicTacToeState.cross)
                {
                }
                
            //First Colum.
            if (cube[0] == (int) TicTacToeState.cross && cube[3] == (int) TicTacToeState.cross && cube[6] == (int) TicTacToeState.cross)
            {
            }
            
            //Middle Colum.
            if (cube[1] == (int) TicTacToeState.cross && cube[4] == (int) TicTacToeState.cross && cube[7] == (int) TicTacToeState.cross)
            {
            }
            //Right Colum.
            if (cube[2] == (int) TicTacToeState.cross && cube[5] == (int) TicTacToeState.cross && cube[8] == (int) TicTacToeState.cross)
            {
            }
            //First Diagonal.
            if (cube[0] == (int) TicTacToeState.cross && cube[4] == (int) TicTacToeState.cross && cube[8] == (int) TicTacToeState.cross)
            {
            }
            
            //Second Diagonal.
            if (cube[20] == (int) TicTacToeState.cross && cube[4] == (int) TicTacToeState.cross && cube[6] == (int) TicTacToeState.cross)
            {
            }

        }
        void GameOver()
        {
            Debug.Log("Game Over");
        }
        

    }
}