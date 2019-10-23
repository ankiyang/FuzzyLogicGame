using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinfeAnimation : MonoBehaviour
{
    public float Angle = 20;
    bool Up = false;
    float timer;
    public float RefreshTime = 1;
    void Start()
    {
        
    }

    void Update()
    {
        timer -=Time .deltaTime ;
        if( timer <= 0)
        {
            Up = !Up;
            timer = RefreshTime;
        }

        if(Up)
        {
            if(Angle > -60)
                Angle -= 5.8F; 
        }
        else
        {
            if(Angle < 60)
                Angle += 5.8F; 
        }
        transform.localEulerAngles  = new Vector3(0, 0,Angle);
    }
}
