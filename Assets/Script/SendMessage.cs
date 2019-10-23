using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendMessage : MonoBehaviour
{
    public delegate void SendArea(int index);
	public event SendArea SendAreaEvent;
    public GameObject PlayerObject;
    public GameObject AttackObject;
    public float Distance;
    public Text DistanceText;
    void Start()
    {
    }

    void Update()
    {
        Distance = Vector3.Distance(PlayerObject.transform.position,AttackObject.transform.position);
        DistanceText.text = "Distance : " + Distance.ToString();
        if(Distance <= 1.5F)
        {
            SendIndex(0);
        }
        else if(Distance > 1.5F && Distance <= 3.5F)
        {
            SendIndex(1);            
        }
        else if(Distance > 3.5F && Distance <= 7)
        {
            SendIndex(2);            
        }
        else if(Distance > 7 && Distance <= 9)
        {
            SendIndex(3);            
        }
        else if(Distance > 9 && Distance <= 10)
        {
            SendIndex(4);            
        }
        else
        {
            SendIndex(99);            
        }    
    }

    public void SendIndex(int index)
    {
        if(SendAreaEvent != null)
        {
           SendAreaEvent(index);
        }   
    }
}
