using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelTrailRebdererHandler : MonoBehaviour
{
    TopDownCarController topDownCarController;
    TrailRenderer trailRenderer;


    void Awake()
    {
       topDownCarController = GetComponentInParent<TopDownCarController>();
        
        trailRenderer = GetComponent<TrailRenderer>();

        trailRenderer.emitting = false;
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(topDownCarController.isTireScreeching(out float lateralVelocity, out bool isBreaking))
        {
            trailRenderer.emitting = true;
        }
        else
        {
            trailRenderer.emitting = false;
        }
    }
}
