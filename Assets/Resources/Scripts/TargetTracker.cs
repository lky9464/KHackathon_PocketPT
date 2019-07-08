using UnityEngine;
using System;
using System.Collections;
namespace Vuforia
{
    public class TargetTracker : MonoBehaviour, ITrackableEventHandler
    {
         public UnityEngine.Video.VideoPlayer videoPlayer;
        private TrackableBehaviour mTrackableBehaviour;
        public event Action OnTrackingFound = () => { };
        public event Action OnTrackingLost = () => { };

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
            print("Test");
            if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED ||
                       newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                print("TargetTracker : onTrackingFound");
                OnTrackingFound();
                 videoPlayer.Play();
            }
            else
            {
                print("TargetTracker : onTrackingLost");
                OnTrackingLost();
                 videoPlayer.Pause();
            }
        }


    }
}