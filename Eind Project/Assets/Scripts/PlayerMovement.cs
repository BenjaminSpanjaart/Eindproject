using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController), typeof(PlayerInputHandler))]
public class PlayerMovement : MonoBehaviour
{
    private CharacterController cController;

    private PlayerInputHandler input;

    private Camera camera;
    
    [SerializeField]private float fMovementSpeed;

    private float rUp;

    private void Start()
    {
        Cursor.visible = false;
        
        cController = GetComponent<CharacterController>();

        camera = Camera.main;
        
        input = GetComponent<PlayerInputHandler>();

        input.movementInput.AddListener(Movement);
        input.rotationInput.AddListener(Rotation);
    }

    private void Movement(float xInput, float yInput)
    {
        var mForward = yInput * cController.transform.forward;
        var mRight = xInput * cController.transform.right;

        Vector3 vMovement = Vector3.Normalize(mForward + mRight);

        cController.SimpleMove(vMovement * fMovementSpeed);
    }

    private void Rotation(float xInput, float yInput)
    {
        rUp = Mathf.Clamp(rUp - yInput, -80, 80);
        var rRight = xInput;
        
        cController.transform.rotation = 
            Quaternion.Euler(0.0f,rRight,0.0f) * 
            cController.transform.rotation;
        
        camera.transform.localRotation = Quaternion.Euler(rUp,0.0f,0.0f);
    }
}
