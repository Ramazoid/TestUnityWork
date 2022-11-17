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
        GameObject[] buttons = Model.Get<GameObject[]>("Buttons");

        foreach (GameObject b in buttons) b.SetActive(true);
    }

    [OnRefresh(3)]
    void Earn()
    {
        Log.Debug("Earn"+Time.time);
    }
}
