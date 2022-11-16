using AxGrid.FSM;
using AxGrid.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[State("AtHome")]
public class AtHome : FSMState 
{
    [Enter]
    void EnterHere()
    {
        Log.Debug("AtHomeState");
    }
   
    [Bind("OnBtn")]
    void OnButtonPress(string buttonName)
    {
        Log.Debug(buttonName);
        switch(buttonName)
        {
            case "ToWork": Parent.Change("ToWork");break;
            case "ToMarket": Parent.Change("TOMarket");break;
        }
    }

}
