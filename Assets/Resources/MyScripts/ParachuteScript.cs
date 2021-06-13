using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParachuteScript : MonoBehaviour
{

    Rigidbody2D m_RigidBody2D;
    // Start is called before the first frame update
    void Awake()
    {
        m_RigidBody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) //RMB
        {
            m_RigidBody2D.gravityScale = 0.02f;
        }
        if (!Input.GetMouseButton(1) && m_RigidBody2D.gravityScale < 1.0f) //set back
        {
            m_RigidBody2D.gravityScale = 1.0f;
        }
    }
}
