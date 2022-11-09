using AxGrid.Base;
using AxGrid.Model;
using AxGrid.Path;
using UnityEngine;

public class BarMover : MonoBehaviourExtBind
{
    private RectTransform RT;
    public float multiplier;

    [OnStart]
    void Init()
    {
        RT = GetComponent<RectTransform>();
    }
    [Bind("Move")]
    void MoveUp(float y)
    {

        RT.anchoredPosition = new Vector2(RT.anchoredPosition.x, Input.mousePosition.y);
    }
    

}