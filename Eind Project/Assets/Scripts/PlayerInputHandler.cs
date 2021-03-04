using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MovementInput : UnityEvent<float, float>
{
}

public class RotationInput : UnityEvent<float, float>
{
}

public class PlayerInputHandler : MonoBehaviour
{
    [HideInInspector]
    public MovementInput movementInput = new MovementInput();
    public RotationInput rotationInput = new RotationInput();

    [SerializeField] private string xAxis, yAxis;
    [SerializeField] private string xMouseAxis, yMouseAxis;

    private void Update()
    {
        var xAxisInput = Input.GetAxis(xAxis);
        var yAxisInput = Input.GetAxis(yAxis);

        var xMouseInput = Input.GetAxis(xMouseAxis);
        var yMouseInput = Input.GetAxis(yMouseAxis);
        
        movementInput.Invoke(xAxisInput, yAxisInput);

        if (xMouseInput != 0f || yMouseInput != 0f)
        {
            rotationInput.Invoke(xMouseInput, yMouseInput);
        }
    }
}
