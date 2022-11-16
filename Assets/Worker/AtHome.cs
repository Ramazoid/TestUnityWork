using AxGrid.FSM;
using AxGrid.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[State("AtHome")]
public class AtHome : FSMState 
{
    // Start is called before the first frame update
    void Start()
    {
        Log.Debug("AthomeState");
    }
    [Bind("OnToWork")]
    private void ToWork()
    {
        Log.Debug("ToWork");
    }
    [Bind("OnBtn")]
    void OnButtonPress(string buttonName)
    {
        Log.Debug(buttonName);
    }

}
