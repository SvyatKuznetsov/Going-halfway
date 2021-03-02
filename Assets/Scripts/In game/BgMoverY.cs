using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMoverY : MonoBehaviour
{
    public float parallaxSpeed;

    private Transform cameraTransform;
    private float lastCameraY;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraY = cameraTransform.position.y;
    }

    private void Update()
    {
        float deltaY = cameraTransform.position.y - lastCameraY;
        transform.position += Vector3.down * (deltaY * parallaxSpeed);
        lastCameraY = cameraTransform.position.y;
    }
}
