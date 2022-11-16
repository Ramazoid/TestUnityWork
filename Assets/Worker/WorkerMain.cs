using AxGrid;
using AxGrid.Base;
using AxGrid.FSM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerMain : MonoBehaviourExtBind
{
    [OnStart]
    private void StartThis()
    {
        Log.Debug("ExMain Start");
        Settings.Fsm = new FSM();
        Settings.Fsm.Add(new AtHome());
       
        Settings.Fsm.Start("AtHome");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
