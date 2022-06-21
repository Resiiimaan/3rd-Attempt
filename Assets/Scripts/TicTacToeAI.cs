using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;
using Random = System.Random;

public enum TicTacToeState{cross, circle}
[System.Serializable] public class WinnerEvent : UnityEvent<int>
{
}
public class TicTacToeAI : MonoBehaviour
{

	int _aiLevel;

	TicTacToeState[,] boardState;

	[SerializeField] private bool _isPlayerTurn;

	[SerializeField] private int _gridSize = 3;
	
	[SerializeField] private TicTacToeState playerState = TicTacToeState.cross;
	[SerializeField] private TicTacToeState aiState = TicTacToeState.circle;

	[SerializeField] private GameObject _xPrefab;

	[SerializeField] private GameObject _oPrefab;

	public UnityEvent onGameStarted;

	//Call This event with the player number to denote the winner
	public WinnerEvent onPlayerWin;

	ClickTrigger[,] _triggers;
	
	//difficulty change 
	[SerializeField] private float AILevel;
	
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