using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 1.5f;
    public Transform m_transform;
	void Start () {
        m_transform = this.transform;
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            m_transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            m_transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            m_transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }
}
