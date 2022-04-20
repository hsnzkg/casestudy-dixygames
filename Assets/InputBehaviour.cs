using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class InputBehaviour : MonoBehaviour
{
    public UnityAction OnFingerDown;
    public UnityAction OnFingerHold;
    public UnityAction OnFingerUp;


    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                OnFingerDown.Invoke();
            }
            else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Moved)
            {
                OnFingerHold.Invoke();  
            }
            else
            {
                OnFingerUp.Invoke();
            }
        }
    }
}
