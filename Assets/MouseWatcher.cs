using AxGrid;
using AxGrid.Base;
using AxGrid.Model;
using AxGrid.Path;
using UnityEngine;

public class MouseWatcher : MonoBehaviourExt
{
    private float MouseY;

    [OnStart]
    private void Init()
    {
        MouseY = Input.mousePosition.y;
    }

    [OnRefresh(0.01f)]
    void GetMouse()
    {
        if(MouseY!=Input.mousePosition.y)
        {

            Settings.Invoke("Move",Input.mousePosition.y);
        }
        
        MouseY = Input.mousePosition.y;
    }
}
