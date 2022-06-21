using System.Collections;   
using System.Collections.Generic;
using UnityEngine;

public class Turns : MonoBehaviour
{
    public GameObject[] cube = new GameObject[9];
    CheckForWinner.Board game = new CheckForWinner.Board();

    int playerState = 1;
    int aiState = 2;

    public void updateBoard()
    {
        // Make sure no piece can be put on top of another piece

        for (int i = 0; i < game.cube.Length; i++)
        {
            if (game.cube[i] == 0)
            {
                cube[i].SetActive(true);
            }
            else if (game.cube[i] == playerState)
            {
                cube[i].SetActive(false);
            }
            else if (game.cube[i] == aiState)
            {
                cube[i].SetActive(false);
            }
        }
    }
}
