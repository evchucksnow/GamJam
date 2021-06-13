using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPointBetweenPlayers : MonoBehaviour
{
    public GameObject ChonkyBoi;
    public GameObject TallBoi;
    Transform m_LocationChonk;
    Transform m_LocationTall;
    Transform m_LocationMiddlePoint;

    private float hold1;
    private float hold2;
    private float hold3;
    private float hold4;
    private float LMP_x;
    private float LMP_y;

    // Start is called before the first frame update
    void Awake()
    {
        m_LocationChonk = ChonkyBoi.GetComponent<Transform>();
        m_LocationTall = TallBoi.GetComponent<Transform>();
        m_LocationMiddlePoint = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateMiddlePoint();
    }

    void UpdateMiddlePoint()
    {
        hold1 = m_LocationChonk.position.x;
        hold2 = m_LocationChonk.position.y;
        hold3 = m_LocationTall.position.x;
        hold4 = m_LocationTall.position.y;

        LMP_x = (hold1 + hold3) / 2; //woah crazy math
        LMP_y = (hold2 + hold4) / 2;

        m_LocationMiddlePoint.position = new Vector2(LMP_x, LMP_y+2.0f); //update the point
    }
}
