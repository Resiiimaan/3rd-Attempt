using System.Collections;   
using System.Collections.Generic;
using UnityEngine;

public class Turns : MonoBehaviour
{
    public GameObject[] cube = new GameObject[9];
    [SerializeField] int[] _cube;

    
    private int unoccupied = 0;
    int playerState = 1;
    int aiState = 2;

    public void updateBoard()
    {
        // Make sure no piece can be put on top of another piece

        for (int i = 0; i < _cube.Length; i++)
        {
            if (_cube[i] == unoccupied)
            {
                cube[i].SetActive(true);
            }
            else if (_cube[i] == playerState)
            {
                cube[i].SetActive(false);
            }
            else if (_cube[i] == aiState)
            {
                cube[i].SetActive(false);
            }
        }
    }
}