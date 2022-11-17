using AxGrid;
using AxGrid.Base;
using AxGrid.FSM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerMain : MonoBehaviourExtBind
{
    public GameObject[] buttons;
    [OnStart]
    private void StartThis()
    {
        Log.Debug("Worker Main Start");
        Settings.Fsm = new FSM();
        Settings.Fsm.Add(new AtHome());
        Settings.Fsm.Add(new ToWork());
        Settings.Fsm.Add(new AtWork());
       
        Settings.Fsm.Start("AtHome");
        Model.Set("Buttons", buttons);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
