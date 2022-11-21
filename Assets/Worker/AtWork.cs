using AxGrid;
using AxGrid.Base;
using AxGrid.FSM;
using AxGrid.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AxGrid.FSM;
using TMPro;
using UnityEngine.UI;

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

    [Loop(1f)]
    void Earn()
    {
        Log.Debug("Change");
        Model.Inc("Account",1);
    }
    
    [Bind("OnBtn")]
    void OnButtonPress(string buttonName)
    {
        GameObject[] buttons = Model.Get<GameObject[]>("Buttons");

        foreach (GameObject b in buttons) b.SetActive(false);

        Log.Debug("ButtonName=[" + buttonName + "]");
        switch (buttonName)
        {
            case "ToWork": Parent.Change("ToWork"); break;
            case "ToMarket": Parent.Change("ToMarket"); break;
        }
    }
}
