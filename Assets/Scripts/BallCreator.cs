using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BallCreator : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject spawnPoint;
    public List<Ball> balls = new List<Ball>();
    public BallSettings setting;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject tempBallObj =  Instantiate(ballPrefab, spawnPoint.transform.position, Quaternion.identity,null);
            Ball tempBall = new Ball(setting, tempBallObj);
            balls.Add(tempBall);
        }
    }

    public Ball GetBall(GameObject ball)
    {
        return balls.Single(x => x.GetBallObject() == ball);
    }

}
