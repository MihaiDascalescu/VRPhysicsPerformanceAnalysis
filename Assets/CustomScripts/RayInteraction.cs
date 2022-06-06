using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class RayInteraction : MonoBehaviour
{
    private XRInteractorLineVisual ray;
    [SerializeField]
    Gradient interactionGradient = new Gradient
    {
        colorKeys = new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
        alphaKeys = new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 1f) },
    };
    [SerializeField]
    Gradient originalGradient = new Gradient
    {
        colorKeys = new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
        alphaKeys = new[] { new GradientAlphaKey(1f, 0f), new GradientAlphaKey(1f, 1f) },
    };

    
    private ChangeRayReticleMaterial changeRayReticleMaterial;
    private InputDevice device;
    public InputDeviceCharacteristics controllerCharacteristics;
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        changeRayReticleMaterial = GetComponent<ChangeRayReticleMaterial>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);
        ray = GetComponent<XRInteractorLineVisual>();
        device = devices[0];
    }

    private void Update()
    {
        device.TryGetFeatureValue(CommonUsages.trigger, out float pinchValue);
        if (pinchValue > 0.3f)
        {
            ray.validColorGradient = interactionGradient;
            ray.invalidColorGradient = interactionGradient;
            changeRayReticleMaterial.ChangeToInteractionMode();
        }
        else
        {
            ray.validColorGradient = originalGradient;
            ray.invalidColorGradient = originalGradient;
            changeRayReticleMaterial.ChangeToInactiveMode();
        }
    }
}
