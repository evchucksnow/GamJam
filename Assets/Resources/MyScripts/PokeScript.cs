using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeScript : MonoBehaviour
{
    public Sprite pokeSprite;
    private PolygonCollider2D m_polygonCollider2D;
    private SpriteRenderer m_spriteRenderer;
    private Animator m_Anim;


    // Start is called before the first frame update
    void Awake()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_polygonCollider2D = gameObject.GetComponent<PolygonCollider2D>();
        m_polygonCollider2D.enabled = false; //start with idle position PolygonCollider2D disabled
        m_Anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_Anim.SetBool("isPoke", true);
            m_polygonCollider2D.enabled = true; //toggle PolygonCollider2D

        }
        if (Input.GetMouseButtonUp(0))
        {
            m_Anim.SetBool("isPoke", false);
            m_polygonCollider2D.enabled = false; //toggle PolygonCollider2D
        }

    }
}