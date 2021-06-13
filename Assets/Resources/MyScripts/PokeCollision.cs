using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeCollision : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody2D;
    public float m_Thrust = 20f;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

    }

    void OnTriggerEnter2D()
    {
        m_Rigidbody2D.AddForce(transform.right * m_Thrust);
        Debug.Log("Circle has been thouroughly poked.");
    }
    
    void OnTriggerStay2D()
    {
        Debug.Log("Circle has been entered.");
    }
}
