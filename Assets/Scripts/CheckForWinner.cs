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
    public static TicTacToeState playerState;
    public TicTacToeState aiState;
    
    [SerializeField] int[] _cube = new int[9];

    void EndTurn()
    {
         // return a 0 if nobody won. return the player number if they won.
            //top row.
            if (_cube[0] == (int) TicTacToeState.cross && _cube[1] == (int) TicTacToeState.cross &&
                _cube[2] == (int) TicTacToeState.cross)
            {
                return WinnerEvent();
            }

            //Middle row.
            else if (_cube[3] == (int) TicTacToeState.cross && _cube[4] == (int) TicTacToeState.cross &&
                _cube[5] == (int) TicTacToeState.cross)
            {
                GameOver();
            }

            //Bottom row.
           else if (_cube[6] == (int) TicTacToeState.cross && _cube[7] == (int) TicTacToeState.cross &&
                _cube[8] == (int) TicTacToeState.cross)
            {
                GameOver();
            }

            //First Colum.
            else if (_cube[0] == (int) TicTacToeState.cross && _cube[3] == (int) TicTacToeState.cross &&
                _cube[6] == (int) TicTacToeState.cross)
            {
                GameOver();
            }

            //Middle Colum.
            else if (_cube[1] == (int) TicTacToeState.cross && _cube[4] == (int) TicTacToeState.cross &&
                _cube[7] == (int) TicTacToeState.cross)
            {
                GameOver();
            }

            //Right Colum.
            else if (_cube[2] == (int) TicTacToeState.cross && _cube[5] == (int) TicTacToeState.cross &&
                _cube[8] == (int) TicTacToeState.cross)
            {
                GameOver();
            }

            //First Diagonal.
            else if (_cube[0] == (int) TicTacToeState.cross && _cube[4] == (int) TicTacToeState.cross &&
                _cube[8] == (int) TicTacToeState.cross)
            {
                GameOver();
            }

            //Second Diagonal.
            else if (_cube[20] == (int) TicTacToeState.cross && _cube[4] == (int) TicTacToeState.cross &&
                _cube[6] == (int) TicTacToeState.cross)
            {
                GameOver();
            }

            ChangeSides();
        }

    /// <summary>
    ///  Stopped here, trying to get the syntax for GAMEOVER!!
    /// </summary>
    public void GameOver()
    {
        for (int i = 0; i < _cube.Length; i++)
        {
            playerState.enabled = false;
        }
    }
    static void ChangeSides()
    {
        playerState = (playerState == TicTacToeState.cross) ? TicTacToeState.circle : TicTacToeState.cross;
    }

    }

    

  