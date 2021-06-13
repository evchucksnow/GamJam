using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingScript : MonoBehaviour
{
    public Rigidbody2D m_rigidBody2D;
    private SpriteRenderer m_spriteRenderer;

    [Tooltip("Place your standard sprite here.")]
    public Sprite standardSprite;
    [Tooltip("Place your talking sprite here.")]
    public Sprite talkingSprite;
    [Tooltip("Place your idle sprite here.")]
    public Sprite idleSprite;

    private float a = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        m_spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        m_rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        //AFK animation
        if (m_rigidBody2D.IsSleeping())
        {
            if (!Input.anyKeyDown && !Input.GetMouseButton(0))
            {
                a += Time.deltaTime;
            }        
            if (a > 5.0f)
            {
                ChangeIdle();
            }
        }
        if (Input.anyKeyDown || Input.anyKey)
        {
            a = 0;
        }
        if ((Input.anyKeyDown || Input.anyKey) && m_spriteRenderer.sprite == idleSprite) 
        {
            m_spriteRenderer.sprite = standardSprite;
            a = 0;
            //Talking animation
        }
        if (Input.GetKeyDown("e") /*&& ability == true*/) //for later when we want to use this ability
        {
            StartCoroutine(ChangeSprite());
        }
    }

    void ChangeIdle()
    {
        m_spriteRenderer.sprite = idleSprite;
    }
    IEnumerator ChangeSprite()
    {
        m_spriteRenderer.sprite = talkingSprite;
        yield return new WaitForSeconds(0.5f);
        m_spriteRenderer.sprite = standardSprite;
        yield return new WaitForSeconds(0.5f);
        m_spriteRenderer.sprite = talkingSprite;
        yield return new WaitForSeconds(0.5f);
        m_spriteRenderer.sprite = standardSprite;
    }
    
    /*void ChangeSprite()
    {
        spriteRenderer.sprite = talkingSprite;
    }*/
}
