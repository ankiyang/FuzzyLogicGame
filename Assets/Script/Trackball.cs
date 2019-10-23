using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trackball : MonoBehaviour
{
    public GameObject AttackObject;
    void OnEnable()
    {
        
    }
    void Start()
    {
        
    }

    void Update()
    {
        transform.localPosition=Vector3.MoveTowards(this.gameObject.transform.position,AttackObject.transform.position,20 * Time.deltaTime);
        transform.LookAt(AttackObject.transform);
    }

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "ObjB")
            Destroy(this.gameObject);
    }
}
