using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
 
public class AddHapticUI : MonoBehaviour {
    private XRController leftController;
    private XRController rightController;
    [SerializeField] private XRRayInteractor leftInteractor;
    [SerializeField] private XRRayInteractor rightInteractor;

    private bool interactor1Active = false;
    private bool interactor2Active = false;
    [SerializeField]private List<GameObject> gameObjects;
 
    private void Start()
    {
     
        foreach (var item in gameObjects) {
            var trigger = item.AddComponent<EventTrigger>();
            var e = new EventTrigger.Entry { eventID = EventTriggerType.PointerEnter };
            e.callback.AddListener(Hover);
            trigger.triggers.Add(e);
            
 
            var e2 = new EventTrigger.Entry { eventID = EventTriggerType.PointerClick };
            e2.callback.AddListener(Select);
           
           // e2.callback.AddListener(leftRayInteraction.OnPointerClick);
           // e2.callback.AddListener(rightRayInteraction.OnPointerClick);
            
            trigger.triggers.Add(e2);

            var e3 = new EventTrigger.Entry{eventID = EventTriggerType.PointerExit};
            trigger.triggers.Add(e3);
            
            
        }
        //leftController// = leftInteractor.GetComponent<InteractorParentReference>().xrController;
        //rightController// = rightInteractor.GetComponent<InteractorParentReference>().xrController;
    }
    
    private void Hover(BaseEventData arg0) {
        StartCoroutine(OnHoverDelayed());
    }
    
    private IEnumerator OnHoverDelayed() {
        yield return new WaitForSeconds(0.02f);
        if (leftInteractor.TryGetHitInfo(out Vector3 v1, out Vector3 v2, out int i1, out bool isValid) && isValid) {
            leftController.inputDevice.SendHapticImpulse(0, leftInteractor.hapticHoverEnterIntensity, leftInteractor.hapticHoverEnterDuration);
        }
        if (rightInteractor.TryGetHitInfo(out Vector3 v3, out Vector3 v4, out int i2, out bool isValid2) && isValid2) {
            rightController.inputDevice.SendHapticImpulse(0, rightInteractor.hapticHoverEnterIntensity, rightInteractor.hapticHoverEnterDuration);
        }
    }
 
    private void Select(BaseEventData arg0) {
        OnSelectEntered();
    }
 
    private void OnSelectEntered() {
        if (leftInteractor.TryGetHitInfo(out Vector3 v1, out Vector3 v2, out int i1, out bool isValid) && isValid) {
            leftController.inputDevice.SendHapticImpulse(0, leftInteractor.hapticSelectEnterIntensity, leftInteractor.hapticSelectEnterDuration);
        }
        if (rightInteractor.TryGetHitInfo(out Vector3 v3, out Vector3 v4, out int i2, out bool isValid2) && isValid2) {
            rightController.inputDevice.SendHapticImpulse(0, rightInteractor.hapticSelectEnterIntensity, rightInteractor.hapticSelectEnterDuration);
        }
    }
}
