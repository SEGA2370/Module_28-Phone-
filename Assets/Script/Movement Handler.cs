using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] InputHandler inputHandler;
    [SerializeField] float ballSpeed;

    void Start()
    {
     if (inputHandler != null)
        {
            Debug.Log("Input Handler is not Assigned");
        }
    }

    private void MoveBall()
    {
        if (inputHandler.IsThereTouchOnScreen())
        {
            Vector2  currentDeltaPosition = inputHandler.GetTouchDeltaPosition();
            currentDeltaPosition *= ballSpeed;
            Vector3 newGravityVector = new Vector3(currentDeltaPosition.x, Physics.gravity.y, currentDeltaPosition.y);
            Physics.gravity = newGravityVector;
        }
    }

    private void Update()
    {
        MoveBall();
    }
}
