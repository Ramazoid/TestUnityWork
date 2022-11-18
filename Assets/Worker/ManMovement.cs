using AxGrid;
using AxGrid.Base;
using AxGrid.Model;
using AxGrid.Path;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManMovement : MonoBehaviourExtBind
{
    private int index;
    private Image IM;
    public Sprite[] MoveSprites;
    private RectTransform RT;
    public RectTransform Home;
    public RectTransform Factory;
    public RectTransform Market;
    private Vector3 startPos;
    private Vector3 endPos;
    private Vector3 deltavector;
    private bool walking;

    [OnStart]
    private void Initi()
    {
        index = 0;
        IM = GetComponent<Image>();
        MoveSprites = Resources.LoadAll<Sprite>("ManWalk");
        RT = GetComponent<RectTransform>();
    }
    // Update is called once per frame
    [OnUpdate]
    void Walking()
    {
        if (walking)
        {
            IM.sprite = MoveSprites[index++];
            if (index == MoveSprites.Length) index = 0;
        }
    }

    [Bind("MoveToWork")]
    private void ToWork()
    {
        RT.localScale = new Vector3(-1, 1, 1);
        Path = new CPath();

        Path.Action(() =>
        {
            startPos = RT.localPosition;
            endPos = Factory.localPosition;
            deltavector = endPos - startPos;
            walking = true;

        })
        .EasingLinear(3, 0, 1, (progress) =>
        {

            RT.localPosition = Vector3.Lerp(startPos,endPos, progress);
        })
        .Action(() =>
        {
            walking = false;
            Settings.Fsm.Change("AtWork");
        });
    }
}
