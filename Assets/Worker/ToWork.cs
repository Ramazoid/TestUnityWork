using AxGrid;
using AxGrid.FSM;
using AxGrid.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[State("ToWork")]
public class ToWork : FSMState
{
   [Enter]
    void EnterHere()
    {
        Log.Debug("State toWork");
        Settings.Invoke("MoveToWork");
    }

    
}
