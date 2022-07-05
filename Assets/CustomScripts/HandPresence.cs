using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
 	public bool showController = false;
	public InputDeviceCharacteristics controllerCharacteristics;
	public List<GameObject> controllerPrefabs;
	//public GameObject handModelPrefab;
	
    public InputDevice targetDevice;
	public GameObject spawnedController;
	private GameObject spawnedHandModel;
	private Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        TryInitialize();
    }

	void TryInitialize()
	{
		List<InputDevice> devices = new List<InputDevice>();
        
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach (var item in devices)
        {
            //Debug.Log(item.name + item.characteristics);
        }

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
			GameObject prefab = controllerPrefabs.Find(controller => controller.name == targetDevice.name);
			if (prefab)
			{
				spawnedController = Instantiate(prefab, transform);
			}
			else
			{
				Debug.LogError("Error");
				spawnedController = Instantiate(controllerPrefabs[0], transform);
			}
			
			
		}
	}
	void UpdateHandAnimation()
	{
		if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
		{
			handAnimator.SetFloat("Trigger", triggerValue);
		}
		else
		{
			handAnimator.SetFloat("Trigger", 0);
		}
		if (targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
		{
			handAnimator.SetFloat("Grip", gripValue);
		}
		else
		{
			handAnimator.SetFloat("Grip", 0);
		}
	}

    // Update is called once per frame
    void Update()
    {
		if (!targetDevice.isValid)
		{
			TryInitialize();
		}
    }
    
}
