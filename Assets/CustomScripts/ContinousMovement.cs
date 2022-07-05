using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ContinousMovement : MonoBehaviour
{
    [SerializeField]private XRNode inputSource;
   
    [SerializeField]private float speed = 1;
  
    [SerializeField]private float additionalHeight = 0.2f;
    
    private Vector2 inputAxis;
    private XROrigin rig;
    
    private InputDevice device; 
    
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        rig = GetComponent<XROrigin>();
        device = InputDevices.GetDeviceAtXRNode(inputSource);
    }

    // Update is called once per frame
    void Update()
    {
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
    }

    private void FixedUpdate()
    {
        CapsuleFollowHeadset();
        //Quaternion headYaw = Quaternion.Euler(0, rig.cameraGameObject.transform.eulerAngles.y, 0);
        Quaternion headYaw = Quaternion.Euler(0,rig.CameraFloorOffsetObject.transform.eulerAngles.y,0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);

        characterController.Move(direction * (speed * Time.fixedDeltaTime));
    }

    private void CapsuleFollowHeadset()
    {
        characterController.height = rig.CameraInOriginSpaceHeight + additionalHeight;//rig.cameraInRigSpaceHeight + additionalHeight;
        Vector3 capsuleCenter = transform.InverseTransformPoint(rig.CameraFloorOffsetObject.transform.position);
        characterController.center = new Vector3(capsuleCenter.x,characterController.height/2 + characterController.skinWidth,capsuleCenter.z);
    }
 
}
