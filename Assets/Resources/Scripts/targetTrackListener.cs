using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Vuforia
{

    public class targetTrackListener : MonoBehaviour
    {

        public bool visiToggle;

        private TargetTracker targetObject = null;

        void Start()
        {
            targetObject = GameObject.Find("ImageTarget (1)").GetComponent<TargetTracker>();
            targetObject.OnTrackingFound += trackingFound;
            //targetObject.OnTrackingLost+= trackingLost;
        }


        void onDestroy()
        {
            targetObject.OnTrackingFound -= trackingFound;
            //targetObject.OnTrackingLost-= trackingLost;
        }


        public void trackingFound()
        {
            if (visiToggle)
            {
                gameObject.SetActive(false);
                visiToggle = false;
            }
            else
            {
                gameObject.SetActive(true);
                visiToggle = true;
            }
        }


    }

}