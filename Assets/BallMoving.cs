using AxGrid;
using AxGrid.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoving : MonoBehaviourExt
{
    private RectTransform RT;
    private Vector2 dir;
    public float speed=5;
    public float verticalSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        RT = GetComponent<RectTransform>();
        
    }

    [OnRefresh(0.01f)]
    void Move()
    {
        dir = Vector2.right * speed + Vector2.down*verticalSpeed;
        RT.anchoredPosition += dir;
        if (RT.anchoredPosition.x <= 0 || RT.anchoredPosition.x > Screen.width)
        {
            speed = -speed;
            Settings.Invoke("PlayBall");
        }
        if (RT.anchoredPosition.y < 0 || RT.anchoredPosition.y > Screen.height)
        {
            verticalSpeed = -verticalSpeed;
            Settings.Invoke("PlayBall");
        }
        }

    private void OnTriggerEnter2D(Collider2D col)
    {
        print("----------------"+col.name);
        speed = -speed;
        
        RectTransform ColRt = col.gameObject.GetComponent<RectTransform>();
        float deltahit = ColRt.anchoredPosition.y - RT.anchoredPosition.y;
        print(deltahit);
        verticalSpeed = deltahit/50;
        Settings.Invoke("PlayBall");
    }

}
