using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [HideInInspector] public FSMGameState FSMGameState;

    [FoldoutGroup("UI")]
    public UiController UiController;

    private void Awake()
    {
        Instance = this;
        FSMGameState = new FSMGameState();
        FSMGameState.AddState(new LobbyState());
        FSMGameState.AddState(new InGameState());
        FSMGameState.AddState(new EndGameState());
        FSMGameState.ChangeState(GameStateID.Lobby);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        FSMGameState.OnUpdate();
    }

    private void FixedUpdate()
    {
        FSMGameState.OnFixedUpdate();
    }

    private void LateUpdate()
    {
        FSMGameState.OnLateUpdate();
    }
}
