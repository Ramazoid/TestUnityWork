using AxGrid.Base;
using AxGrid.Model;
using AxGrid.Path;
using UnityEngine;

public class StartUp : MonoBehaviourExt
{
    [OnStart]
    private void Init()
    {
        Model.Set("MetaVar", 0);

    }
   
    public void Inc()
    {
        Model.Inc("Metavar");
    }
    public void Dec()
    {
        Model.Dec("Metavar");
    }
}
