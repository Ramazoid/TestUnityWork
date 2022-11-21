using AxGrid;
using AxGrid.Base;
using AxGrid.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Earn : MonoBehaviourExtBind
{
    private int moneyAmount;
    private Text AccountText;

    [OnStart]
  private void EnterHere()
    {
        moneyAmount = 0;
        AccountText = GetComponent<Text>();
    }

    [Bind("OnAccountChanged")]
    private void Earning()
    {
        Log.Debug("event Change");
        moneyAmount++;
        AccountText.text = moneyAmount.ToString();

    }
}
