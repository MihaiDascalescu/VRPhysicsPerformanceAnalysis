using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnableInteractions : MonoBehaviour
{
    [SerializeField] private List<XRSimpleInteractable> interactables;

    public void EnableInteraction()
    {
        foreach (var interactable in interactables)
        {
            interactable.gameObject.layer = LayerMask.NameToLayer("UI");
        }
    }
}
