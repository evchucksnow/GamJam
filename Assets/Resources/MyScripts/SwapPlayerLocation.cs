using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapPlayerLocation : MonoBehaviour
{
    public GameObject ChonkyBoi;
    public GameObject TallBoi;
    Transform m_LocationChonk;
    Transform m_LocationTall;
    Animator m_Anim;
    Rigidbody2D m_RigidBoidy2D;


    private float hold1;
    private float hold2;
    private float hold3;
    private float hold4;

    private int count = 0;
    private float a = 0.0f;

    // Start is called before the first frame update
    void Awake()
    {
        m_LocationChonk = ChonkyBoi.GetComponent<Transform>();
        m_LocationTall = TallBoi.GetComponent<Transform>();
        m_Anim = TallBoi.GetComponent<Animator>();
        m_RigidBoidy2D = TallBoi.GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if (m_RigidBoidy2D.velocity.x == 0.0f)
        {
            a += Time.deltaTime;
        }
        if (Input.GetKeyDown("q") && count < 1 && a > 0.05f) //make sure walking animation isn't playing.
        {
            StartCoroutine(SwapPlaces());
            m_Anim.SetBool("isSwap", true);
            StartCoroutine(PauseFrame()); //give aframe to update
            count++;
        }
        if (m_RigidBoidy2D.velocity.x != 0)
        {
            a = 0.0f;
        }
    }
    private IEnumerator SwapPlaces()
    {
        yield return new WaitForSeconds(1.5f);
        hold1 = m_LocationChonk.position.x;
        hold2 = m_LocationChonk.position.y;
        hold3 = m_LocationTall.position.x;
        hold4 = m_LocationTall.position.y;

        m_LocationChonk.position = new Vector2(hold3, hold4);
        m_LocationTall.position = new Vector2(hold1, hold2);
        count = 0; //reset so co-routine can run again.
    }

    private IEnumerator PauseFrame()
    {
        yield return null;
        m_Anim.SetBool("isSwap", false);

    }
}
