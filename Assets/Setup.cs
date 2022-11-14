using AxGrid;
using AxGrid.Base;
using AxGrid.FSM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviourExtBind
{
    public GameObject Ball;
    public FSM Fsm;
    public Transform canv;

    [OnStart]
    private void Init()
    {
        
        Model.Set("Ball", Ball);
        Model.Set("Canv", canv);
       Fsm = new FSM(); Debug.Log("Init"+Fsm);
        Fsm.Add(new BallInit());
       Fsm.Add(new GrowBall());
        
    }
    public void Go()
    {
        Fsm.Start("Init");
    }
}
