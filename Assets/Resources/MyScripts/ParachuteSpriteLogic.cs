using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class ParachuteSpriteLogic : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    PlatformerCharacter2D m_PlatformerCharacter2D;

    private int count = 0;

    void Awake()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_PlatformerCharacter2D = GetComponentInParent<PlatformerCharacter2D>();
        m_SpriteRenderer.enabled = false; //start with parachute closed
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) //RMB
        {
            m_SpriteRenderer.enabled = true; //start with parachute closed
        }
        else if (Input.GetMouseButton(1) && !m_PlatformerCharacter2D.m_Grounded) //RMB
        {
            m_SpriteRenderer.enabled = true; //start with parachute closed
        }
        if (Input.GetMouseButtonUp(1) || m_PlatformerCharacter2D.m_Grounded) //set back
        {
            m_SpriteRenderer.enabled = false;
        }
    }
}
