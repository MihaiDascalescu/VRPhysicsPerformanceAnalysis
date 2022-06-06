using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class AnimateController : MonoBehaviour
{
    private Animator animator;
    private HandPresence handPresence;
    private static readonly int TriggerPressed = Animator.StringToHash("Trigger");
    private static readonly int Grip = Animator.StringToHash("Grip");
    

    void Start()
    {
        handPresence = GetComponent<HandPresence>();
        animator = handPresence.spawnedController.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (handPresence.targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            animator.SetFloat(TriggerPressed, triggerValue);
        }
        else
        {
            animator.SetFloat(TriggerPressed, 0);
        }
        if (handPresence.targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            animator.SetFloat(Grip, gripValue);
        }
        else
        {
            animator.SetFloat(Grip, 0);
        }
    }
    
    
}
