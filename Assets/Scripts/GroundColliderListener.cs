using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColliderListener : MonoBehaviour
{
    [SerializeField]private BallCreator ballCreator;
    private void Start()
    {
        ballCreator = GameManager.Instance.ballCreator;
    }

    private void OnCollisionEnter(Collision collision)
    {
        ballCreator.GetBall(collision.gameObject).OnAccelerate();
    }

    private void OnCollisionStay(Collision collision)
    {
        ballCreator.GetBall(collision.gameObject).OnAccelerate();
    }
    private void OnCollisionExit(Collision collision)
    {
        ballCreator.GetBall(collision.gameObject).OnRelease();
    }
}
