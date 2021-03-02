using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameMoverY : MonoBehaviour
{
    public GameObject camera;
    
    private Vector2 startPos;
    private Camera cam;

    private void Start()
    {
        cam = camera.transform.GetChild(0).gameObject.GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = cam.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            float tmpPos = cam.ScreenToWorldPoint(Input.mousePosition).y - startPos.y;
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y - tmpPos, -181f, -170), transform.position.z);
        }
    }
}
