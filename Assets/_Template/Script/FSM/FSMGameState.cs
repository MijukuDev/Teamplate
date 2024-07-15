using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMGameState : MonoBehaviour
{
    private GameStateID _gameStateID;

    private GameState[] _gameStates;

    public void AddState(GameState gameState)
    {
        int index = (int)gameState.GetStateID();
        _gameStates[index] = gameState;
    }

    public void ChangeState(GameStateID gameStateID)
    {
        GetState(_gameStateID)?.OnExit();
        _gameStateID = gameStateID;
        GetState(_gameStateID)?.OnEnter();
    }

    public GameState GetState(GameStateID gameStateID)
    {
        int index = (int)gameStateID;
        return _gameStates[index];
    }
    public GameStateID ID_STATE => _gameStateID;

    public void OnUpdate()
    {
        GetState(_gameStateID)?.OnUpdate();
    }

    public void OnFixedUpdate()
    {
        GetState(_gameStateID)?.OnFixedUpdate();
    }

    public void OnLateUpdate()
    {
        GetState(_gameStateID)?.OnLateUpdate();
    }
}
