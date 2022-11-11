using AxGrid;
using AxGrid.Base;
using AxGrid.Model;
using AxGrid.Path;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviourExtBind
{
    private RectTransform RT;
    private Vector2 StartPosition;
    private Vector2 currentStartPosition;
    private Vector2 nextdeltaposition;
    public int myNumber;

    [OnStart]
    void Init()
    {
        RT = GetComponent<RectTransform>();
        StartPosition = RT.anchoredPosition;
        
        myNumber = (int)Model.GetInt("Balls");
        
        
    }
    [Bind("Bounce")]
    void Bounce(int ballNumber)
    {
        if ((ballNumber != -1) && (ballNumber != myNumber)) return;

        Path = new CPath();

        Path.EasingBounceEaseIn(3, 0, Random.Range(0,200)+100, (pos) =>
           {
               
               RT.anchoredPosition = StartPosition + Vector2.up * pos;
           })
        .Action(() =>
        {
            currentStartPosition = RT.anchoredPosition;
            nextdeltaposition = Random.insideUnitCircle * 5;
        })
        .EasingBounceEaseOutIn(3, 0, 100, (progress) => {
            RT.anchoredPosition = currentStartPosition + nextdeltaposition * progress;

            })
        .Action(() =>
        {
            currentStartPosition = RT.anchoredPosition;
            nextdeltaposition = StartPosition - RT.anchoredPosition;
        })
        .EasingBounceEaseOutIn(2, 0, 1, (progress) => {
            RT.anchoredPosition = currentStartPosition + nextdeltaposition * progress;

        })
        .Action(() =>
        {
            Settings.Invoke("BouncingDone");
        });
    }

}
