using AxGrid.Base;
using AxGrid.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Changer : MonoBehaviourExtBind
{
    private Text TextIndicator;

    [OnStart]
    private void OnServerInitialized()
    {
        TextIndicator = GetComponent < Text > ();  

    }
    [Bind("OnMetavarChanged")]
    void Changed(string val)
    {
        TextIndicator.text = val;
    }


}
