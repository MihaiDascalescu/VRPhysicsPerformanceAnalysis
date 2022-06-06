using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class ChangeRayReticleMaterial : MonoBehaviour
{
    [FormerlySerializedAs("highlightMaterial")] [SerializeField] private Color highlightColor;
    private Color originalColor;

    [SerializeField]private SpriteRenderer reticleMeshRenderer;
    private Transform reticleTransform;
    void Start()
    {
        reticleTransform = reticleMeshRenderer.transform;
        originalColor = reticleMeshRenderer.color;
    }
    public void ChangeToInteractionMode()
    {
        reticleTransform.localScale = new Vector3(.7f,.7f,.7f);
        reticleMeshRenderer.color = highlightColor;
    }

    public void ChangeToInactiveMode()
    {
        reticleMeshRenderer.color = originalColor;
        reticleTransform.localScale = new Vector3(.5f,.5f,.5f);
    }
    
    
}
