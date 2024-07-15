using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStateID
{
    Lobby,
    InGame,
    EndGame,
}

public interface GameState
{
    public GameStateID GetStateID();

    public void OnEnter();

    public void OnExit();

    public void OnUpdate();

    public void OnFixedUpdate();

    public void OnLateUpdate();
}
