using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalManager : MonoBehaviour
{
    public SendMessage AreaList;
    public GameObject AttackObject;
    public GameObject BulletObj;
    public GameObject MagicBallObj;
    public GameObject KinfeObj;
    public GameObject PlayerObject;
    public bool Action1;
    public bool Action2;
    public bool Action3;
    public bool Action4;
    public bool Action5;      
    public float Hatred;
    public Text HatredText;
    public Text AttackText;

    float timer;
    public float RefreshTime = 1;

    void Awake() 
    {
        AreaList.SendAreaEvent += ChangeAction;
    }
    void Start()
    {
        
    }

    void Update()
    {
        timer -=Time .deltaTime ;
        if( timer <= 0)
        {
            DoAction();
            timer = RefreshTime;
        }       
    }
    public void RefreshData()
    {
        Action1 = false;
        Action2 = false;
        Action3 = false;
        Action4 = false;
        Action5 = false;
    } 
    public void ChangeAction(int Index)
    {
        RefreshData();
        if (Index == 0)
        {
            Action1 = true;
        }
        else if(Index == 1)
        {
            Action2 = true;
        }
        else if(Index == 2)
        {
            Action3 = true;
        }
        else if(Index == 3)
        {
            Action4 = true;
        }  
        else if(Index == 4)
        {
            Action5 = true;
        }          
        else
        {
            Hatred = 1;
        }             
    }
    public void DoAction()
    {
        KinfeObj.gameObject.SetActive(false);
        if ((Action1 && Hatred > 0) ||(Action2 && Hatred > 0))
        {
            AttackMelee();
        }
        else if((Action3 && Hatred > 0) || (Action4 && Hatred == 2))
        {
            
            AttackShooting();
        }
        else if((Action4 && Hatred > 2) || (Action5 && Hatred > 1))
        {
            AttackSpell();
        }        
        else
        {
            AttackStop();
        }
    }

    public void AttackMelee()
    {
        if(Hatred  < 5)
            Hatred ++;
        HatredText.text = "Hatred : " + Hatred.ToString();
        AttackText.text = "Attack : Melee";
        KinfeObj.gameObject.SetActive(true);
        Debug.Log("Melee");
    }
    public void AttackShooting()
    {
        if(Hatred  < 5)
            Hatred ++;
        HatredText.text = "Hatred : " + Hatred.ToString();
        AttackText.text = "Attack : Shooting";
        Debug.Log("crossbow");
        GameObject Temp = Instantiate(BulletObj);
        Temp.transform.position = PlayerObject.transform.position;
        Temp.gameObject.SetActive(true);
    }   
    public void AttackSpell()
    {
        if(Hatred  < 5)
            Hatred ++;
        HatredText.text = "Hatred : " + Hatred.ToString();
        AttackText.text = "Attack : Spell";
        Debug.Log("Fireball");
        GameObject Temp = Instantiate(MagicBallObj);
        Temp.transform.position = PlayerObject.transform.position;
        Temp.gameObject.SetActive(true);
    }   
     public void AttackStop()
    {
        HatredText.text = "Hatred : " + Hatred.ToString();
        AttackText.text = "Attack : None";
        Debug.Log("No Action");
    }            

}
