using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball
{
    [SerializeField] private BallSettings setting;
    [SerializeField] private GameObject obj;
    [SerializeField] private Rigidbody rb;

    public Ball(BallSettings setting, GameObject obj)
    {
        this.setting = setting;
        this.obj = obj;
        this.rb = obj.GetComponent<Rigidbody>();
        GameManager.Instance.inputManager.OnFingerDown += OnPress;
        
    }

    public void OnPress()
    {
        Vector3 tempForce = new Vector3(0, setting.verticalForce, 0);
        rb.AddForce(tempForce,setting.forceMode);
    }

    public void OnRelease()
    {
        //nothing
    }

    public GameObject GetBallObject()
    {
        return obj;
    }

    public void OnAccelerate()
    {
        Vector3 tempForce = new Vector3(0, 0, setting.horizontalForce);
        rb.AddForce(tempForce, setting.forceMode);
    }

    public void Jump()
    {

    }
}
