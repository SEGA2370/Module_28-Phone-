using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomDetection : MonoBehaviour
{
    private float initialDistance;
    private Vector3 initialScale;

    void Update()
    {
        // If two fingers are touching the screen
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            if (touch1.phase == TouchPhase.Began || touch2.phase == TouchPhase.Began)
            {
                initialDistance = Vector2.Distance(touch1.position, touch2.position);
                initialScale = transform.localScale;
            }
            // If the touches are moving, calculate the new distance and apply the scale change
            else if (touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved)
            {
                float currentDistance = Vector2.Distance(touch1.position, touch2.position);

                if (Mathf.Approximately(initialDistance, 0))
                {
                    return; // Prevent division by zero
                }

                float factor = currentDistance / initialDistance;
                transform.localScale = initialScale * factor;
            }
        }
    }
}
