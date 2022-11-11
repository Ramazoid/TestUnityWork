using AxGrid;
using AxGrid.Base;
using AxGrid.Model;
using AxGrid.Path;
using UnityEngine;
using UnityEngine.UI;

public class StartUp : MonoBehaviourExtBind
{
    public Button bounceButton;
    public GameObject Ball;
    [OnStart]

    private void Init()
    {
        Model.Set("Balls", 0);
        

    }
   
    public void Inc()
    {
        Model.Inc("Metavar");
    }
    public void Dec()
    {
        Model.Dec("Metavar");
    }
    public void Bounce()
    {
        bounceButton.interactable = false;
        Settings.Invoke("Bounce",-1);
    } public void BounceRandom()
    {
        bounceButton.interactable = false;
        Settings.Invoke("Bounce",Random.Range(0,(int)Model.Get("Balls")));
    }
    public void MoreBall()
    {
        Model.Inc("Balls");
        Vector2 newpos = new Vector2(Random.Range(0, Screen.width), Random.Range(0, Screen.height));
        GameObject newBall = Instantiate(Ball,Ball.transform.parent);
        newBall.GetComponent<RectTransform>().anchoredPosition = newpos;
    }
    [Bind("BouncingDone")]
    void BouncingDone()
    {
        bounceButton.interactable = true;
    }
}
