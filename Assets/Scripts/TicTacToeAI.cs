using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = System.Random;

public enum TicTacToeState{none, cross, circle}

public class Board
{
	public int[] Grid
	{
		get; set;
	}

	public Board()
	{
		Grid = new int [9];

// initialize the board
//set all squares to empty
		for (int i = 0; i < 9; i++)
		{
			Grid[i] = 0;
		}

	}

	public bool isBoardFull()
	{

		bool isFull = true;
// assume the board is full. If an exception is found, change the value
		for (int i =0; i < Grid.Length; i++)
		{
			if (Grid[i] == 0)
			{
				isFull = false;
			}

		}
		return isFull;

	}

	public int checkForWinner()
	{
// return a 0 if nobody won. return the player number if they won.

//top row.
		if(Grid[0] == Grid[1] && Grid[1] == Grid[2])
		{
			return Grid[0];
		}
//second row.
		if(Grid[3] == Grid[4] && Grid[4] == Grid[5])
		{
			return Grid[3];
		}
//third row.
		if(Grid[6] == Grid[7] && Grid[7] == Grid[8])
		{
			return Grid[6];
		}

//first column.
		if(Grid[0] == Grid[3] && Grid[3] == Grid[6])
		{
			return Grid[0];
		}
//second column.
		if(Grid[1] == Grid[4] && Grid[4] == Grid[7])
		{
			return Grid[1];
		}
//third column.
		if(Grid[2] == Grid[5] && Grid[5] == Grid[8])
		{
			return Grid[2];
		}
//first diagonal.
		if(Grid[0] == Grid[4] && Grid[4] == Grid[8])
		{
			return Grid[0];
		}
//second diagonal.
		if(Grid[2] == Grid[4] && Grid[4] == Grid[6])
		{
			return Grid[2];
		}

		return 0;

	}

}

[System.Serializable]
public class WinnerEvent : UnityEvent<int>
{
}

public class TicTacToeAI : MonoBehaviour
{

	int _aiLevel;

	TicTacToeState[,] boardState;

	[SerializeField]
	private bool _isPlayerTurn;

	[SerializeField]
	private int _gridSize = 3;
	
	[SerializeField]
	private TicTacToeState playerState = TicTacToeState.cross;
	TicTacToeState aiState = TicTacToeState.circle;

	[SerializeField]
	private GameObject _xPrefab;

	[SerializeField]
	private GameObject _oPrefab;

	public UnityEvent onGameStarted;

	//Call This event with the player number to denote the winner
	public WinnerEvent onPlayerWin;

	ClickTrigger[,] _triggers;
	
	//difficulty change 
	[SerializeField] 
	private float AILevel;
	
	float CalculateWaveDifficulty()
	{
		float difficulty = 3;
		//foreach (GameObject cube in TicTacToeState);
		{
			//difficulty += TicTacToeState.getComponent<Points>().points;
		}
		//difficulty /= (amountofcubes *6);

		return difficulty;

	}
	private void Awake()
	{
		if(onPlayerWin == null){
			onPlayerWin = new WinnerEvent();
		}
	}

	public void StartAI(int AILevel){
		_aiLevel = AILevel;
		StartGame();
	}

	public void RegisterTransform(int myCoordX, int myCoordY, ClickTrigger clickTrigger)
	{
		_triggers[myCoordX, myCoordY] = clickTrigger;
	}

	private void StartGame()
	{
		_triggers = new ClickTrigger[3,3];
		onGameStarted.Invoke();
	}

	public void PlayerSelects(int coordX, int coordY){

		SetVisual(coordX, coordY, playerState);
	}

	public void AiSelects(int coordX, int coordY){

		SetVisual(coordX, coordY, aiState);
	}

	private void SetVisual(int coordX, int coordY, TicTacToeState targetState)
	{
		Instantiate(
			targetState == TicTacToeState.circle ? _oPrefab : _xPrefab,
			_triggers[coordX, coordY].transform.position,
			Quaternion.identity
		);
	}
}