using AxGrid;
using AxGrid.Base;
using AxGrid.FSM;
using AxGrid.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[State("AtWork")]
public class AtWork : FSMState
{

    [Enter]

    void EnterHere()
    {
        Log.Debug("State AtWork");
        GameObject[] buttons = Model.Get<GameObject[]>("Buttons");

        foreach (GameObject b in buttons) b.SetActive(true);
    }

    [Loop(3f)]
    void Earn()
    {
        Log.Debug("Earn"+Time.time);
    }
    [One(3f)]
    private void Earning()
    {
        Log.Debug("Earning" + Time.time);
    }
}
