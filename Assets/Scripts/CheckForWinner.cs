using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CheckForWinner : MonoBehaviour
{
    public class Board
    {
        public TicTacToeState playerState = TicTacToeState.cross;
        public TicTacToeState aiState = TicTacToeState.circle;

        Board game = new Board();
        public int[] cube;

        public int WinnerEvent()
        {
// return a 0 if nobody won. return the player number if they won.

//top row.
            if (cube[0] == cube[1] && cube[1] == cube[2])
            {
                return cube[0];
            }

//second row.
            if (cube[3] == cube[4] && cube[4] == cube[5])
            {
                return cube[3];
            }

//third row.
            if (cube[6] == cube[7] && cube[7] == cube[8])
            {
                return cube[6];
            }

//first column.
            if (cube[0] == cube[3] && cube[3] == cube[6])
            {
                return cube[0];
            }

//second column.
            if (cube[1] == cube[4] && cube[4] == cube[7])
            {
                return cube[1];
            }

//third column.
            if (cube[2] == cube[5] && cube[5] == cube[8])
            {
                return cube[2];
            }

//first diagonal.
            if (cube[0] == cube[4] && cube[4] == cube[8])
            {
                return cube[0];
            }

//second diagonal.
            if (cube[2] == cube[4] && cube[4] == cube[6])
            {
                return cube[2];
            }

            return 0;

        }
    }
}
