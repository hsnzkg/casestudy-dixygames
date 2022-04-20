using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
    public InputBehaviour inputManager;
    public BallCreator ballCreator;
    private void Awake()
    {
        inputManager =  transform.parent.GetComponentInChildren<InputBehaviour>();
        ballCreator = transform.parent.GetComponentInChildren<BallCreator>();
    }
}
