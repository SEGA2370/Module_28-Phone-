using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset; // Offset from the target's position

    void LateUpdate()
    {
        if (target != null)
        {
            // Update the position of the camera
            transform.position = target.position + offset;
        }
    }
}
