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
        GameObject[] buttons = Model.Get<GameObject[]>("Buttons");

        foreach (GameObject b in buttons) b.SetActive(false);
        //Model.Set("BtnToWorkEnable", false);

        Model.Set("Btn{ToWork}Enable", false);
        Log.Debug("ButtonName=["+buttonName+"]");
        switch(buttonName)
        {
            case "ToWork": Parent.Change("ToWork");break;
            case "ToMarket": Parent.Change("TOMarket");break;
        }
    }

}
