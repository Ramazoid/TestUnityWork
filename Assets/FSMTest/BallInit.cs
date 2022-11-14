using AxGrid;
using AxGrid.Base;
using AxGrid.FSM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[State("Init")]
public class BallInit : FSMState
{
    private GameObject Ball;
   

    [Enter]
    private void EnterHere()
    {
        Debug.Log("BallInit");
        
        Ball = GameObject.Instantiate(Model.Get<GameObject>("Ball"),Model.Get<Transform>("Canv"));
        
        Ball.transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Model.Set("BallTransform", Ball.transform);
        
        Model.Set("Ball", Ball);
        Parent.Change("GrowBall");
        
    }
    [OnUpdate]
    private void Updada()
    {
        

    }
    [Exit]
    private void ExitHere()
    {

    }
}
