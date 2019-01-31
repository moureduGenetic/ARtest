using Vuforia;
using UnityEngine;

public class TargetDetection : DefaultTrackableEventHandler
{
    public GameObject bust;
    private Animator bustAnimator;

    //Executes when tracker is found
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
    }

    //Executes when tracker is lost
    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        
    }
}