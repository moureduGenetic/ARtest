using System.Collections;
using System.Collections.Generic;
using Vuforia;
using UnityEngine;

public class TargetDetection : MonoBehaviour, ITrackableEventHandler
{
    [SerializeField]
    private Animator bustAnimator;
    private TrackableBehaviour mTrackableBehaviour;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }        
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Executes this code when target is tracked
            bustAnimator.enabled = true;
        }
        else
        {
            // Executes this code when target is no longer tracked
            
        }
    }
}