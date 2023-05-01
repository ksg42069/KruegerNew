using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class Movement : MonoBehaviour
{
    public XRNode inputSource;
    Vector2 inputAxis;
    CharacterController character;
    private XROrigin rig;
    public LayerMask groundLayer;

    public float additionalHeight = 0.1f;
    public float speed = 1.0f;
    public float gravity = -9.8f;
    float fallSpeed;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        rig = GetComponent<XROrigin>();
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
    }

    private void FixedUpdate()
    {
        CapsuleFollowHeadset();
        
        Quaternion headYaw = Quaternion.Euler(0, rig.Camera.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);

        character.Move(direction * Time.fixedDeltaTime * speed);

        //fall
        bool isGrounded = CheckIfGround();
        if (isGrounded)
            fallSpeed = 0f;
        else
            fallSpeed += gravity * Time.fixedDeltaTime;

        character.Move(Vector3.up * fallSpeed * Time.fixedDeltaTime);

    }

    void CapsuleFollowHeadset()
    {
        character.height = rig.CameraInOriginSpaceHeight + additionalHeight;
        Vector3 capsuleCentre = transform.InverseTransformPoint(rig.CameraFloorOffsetObject.transform.position);
        character.center = new Vector3(capsuleCentre.x, character.height / 2 + character.skinWidth, capsuleCentre.z); 
    }
    
    bool CheckIfGround()
    {
        Vector3 rayStart = transform.TransformPoint(character.center);
        float rayLength = character.center.y + 0.01f;

        bool hasHit = Physics.SphereCast(rayStart, character.radius, Vector3.down, out RaycastHit hitInfo, rayLength, groundLayer);
        return hasHit;
    }
}
