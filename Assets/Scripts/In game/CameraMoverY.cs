using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoverY : MonoBehaviour
{
    private Vector2 startPos;
    private Camera camera;

    //other
    public float speed;
    private float targetPos;
    //

    private void Start()
    {
        camera = gameObject.transform.GetChild(0).gameObject.GetComponent<Camera>();
        //other
        targetPos = transform.position.y;
        //
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = camera.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            float tmpPos = camera.ScreenToWorldPoint(Input.mousePosition).y - startPos.y;
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y - tmpPos, -190.5f, -45), transform.position.z);
            
            //other
            //targetPos = Mathf.Clamp(transform.position.x - tmpPos, 0, 21);
            //
        }
        
        //other
        //transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetPos, speed * Time.deltaTime), transform.position.y, transform.position.z);
        //
    }
}
