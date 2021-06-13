using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParachuteSpriteLogic : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    Rigidbody2D m_RigidBody2D;

    private int count = 0;

    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_RigidBody2D = GetComponentInParent<Rigidbody2D>();
        m_SpriteRenderer.enabled = !m_SpriteRenderer.enabled; //start with parachute closed
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) //RMB
        {
            m_SpriteRenderer.enabled = !m_SpriteRenderer.enabled; //start with parachute closed
        }
        if (!Input.GetMouseButton(1) && m_RigidBody2D.gravityScale < 1.0f) //set back
        {
            m_SpriteRenderer.enabled = !m_SpriteRenderer.enabled; //start with parachute closed
        }
    }
}
