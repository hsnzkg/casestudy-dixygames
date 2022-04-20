using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/BallSetting", order = 1)]
public class BallSettings : ScriptableObject
{
    public float horizontalForce;
    public float verticalForce;
    public Vector3 maxVelocity;
    public ForceMode forceMode;
    public string collisionTag;
}
