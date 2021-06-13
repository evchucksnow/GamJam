using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmHitboxScript : MonoBehaviour
{
    private PolygonCollider2D m_polygonCollider2D;
    bool m_checkForPoke = false;
    private bool poke = false;

    // Start is called before the first frame update
    void Start()
    {
        m_polygonCollider2D = gameObject.GetComponentInParent<PolygonCollider2D>();
        m_checkForPoke = gameObject.GetComponentInParent<PokeScript>();
        m_polygonCollider2D.enabled = !m_polygonCollider2D.enabled; //start with idle position PolygonCollider2D disabled

    }

    // Update is called once per frame
    void Update()
    {
        if (m_checkForPoke == true && poke == false)
        {
            m_polygonCollider2D.enabled = !m_polygonCollider2D.enabled; //toggle PolygonCollider2D
            poke = true;
        }
        else if (m_checkForPoke == false && poke == true)
        {
            m_polygonCollider2D.enabled = !m_polygonCollider2D.enabled; //toggle PolygonCollider2D
            poke = false;
        }
    }

}
