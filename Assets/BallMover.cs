using AxGrid.Base;
using AxGrid.Model;
using AxGrid.Path;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviourExtBind
{
    private Transform BallTransform;

    [OnStart]
    void EnterHere()
    {
        
    }

    [Bind("DoGrow")]
    private void DoGrow()
    {
        BallTransform = Model.Get<Transform>("BallTransform");
        Path = new CPath();
        Path.EasingBounceEaseIn(2, 0.0001f, 1, (scale) =>
        {
            Debug.Log(scale);
            BallTransform.localScale = Vector3.one * scale;
        });
    }
}
