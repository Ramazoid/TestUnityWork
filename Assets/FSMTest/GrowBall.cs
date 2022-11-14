using AxGrid;
using AxGrid.Base;
using AxGrid.FSM;
using AxGrid.Path;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[State("GrowBall")]
public class GrowBall : FSMState
{
    public Transform BallTransform;
    [Enter]
    private void EnterHere()
    {
        BallTransform = Model.Get<Transform>("BallTransform");
        BallTransform.localScale = Vector3.one / 1000;
        Settings.Invoke("DoGrow");
        
        
        
        
    }

    
}
