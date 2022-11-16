using AxGrid.FSM;
using AxGrid.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtHome : FSMState 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [Bind("OnToWork")]
    private void ToWork()
    {
        Log.Debug("ToWork");
    }
}
