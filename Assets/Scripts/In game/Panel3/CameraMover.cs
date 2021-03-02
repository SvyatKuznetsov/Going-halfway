using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CameraMover : MonoBehaviour
{
    public GameObject controller;
    public bool isStoppedPanel5Main = false;
    public bool isStoppedPanel5Dop = false;
    
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
        targetPos = transform.position.x;
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
            if (gameObject.name == "ForCameraPanel4")
            {
                if (transform.position.x >= 87.4 && transform.position.x <= 87.5)
                {
                    gameObject.GetComponent<CameraMover>().enabled = false;
                    controller.GetComponent<ControllerPanel4>().enabled = true;
                }
                float tmpPos = camera.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
                transform.position = new Vector3(Mathf.Clamp(transform.position.x - tmpPos, 0, 87.5f), transform.position.y, transform.position.z);
            }
            else if (gameObject.name == "ForCameraPanel5Main")
            {
                if (!isStoppedPanel5Main)
                {
                    if (transform.position.x >= 20 && transform.position.x <= 20)
                    {
                        gameObject.GetComponent<CameraMover>().enabled = false;
                        isStoppedPanel5Main = true;
                        gameObject.GetComponent<ControllerPanel5Main>().enabled = true;
                    }
                    float tmpPos = camera.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x - tmpPos, 0, 20), transform.position.y, transform.position.z);
                }
                else
                {
                    if (transform.position.x >= 65 && transform.position.x <= 65)
                    {
                        gameObject.GetComponent<CameraMover>().enabled = false;
                    }
                    float tmpPos = camera.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x - tmpPos, 0, 65), transform.position.y, transform.position.z);
                }
            }
            else if (gameObject.name == "ForCameraPanel5Dop")
            {
                if (!isStoppedPanel5Dop)
                {
                    if (transform.position.x >= 59 && transform.position.x <= 59)
                    {
                        gameObject.GetComponent<CameraMover>().enabled = false;
                        isStoppedPanel5Dop = true;
                        controller.GetComponent<ControllerPanel5Dop>().enabled = true;
                    }
                    float tmpPos = camera.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x - tmpPos, 0, 59), transform.position.y, transform.position.z);
                }
                else
                {
                    if (transform.position.x >= 114 && transform.position.x <= 114)
                    {
                        gameObject.GetComponent<CameraMover>().enabled = false;
                        Invoke(nameof(EnableControllerPanel5Dop), 1f);
                    }
                    float tmpPos = camera.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x - tmpPos, 0, 114), transform.position.y, transform.position.z);
                }
            }
            else
            {
                float tmpPos = camera.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
                transform.position = new Vector3(Mathf.Clamp(transform.position.x - tmpPos, 0, 136), transform.position.y, transform.position.z);
            }

            //other
            //targetPos = Mathf.Clamp(transform.position.x - tmpPos, 0, 21);
            //
        }
        
        //other
        //transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetPos, speed * Time.deltaTime), transform.position.y, transform.position.z);
        //
    }

    private void EnableControllerPanel5Dop()
    {
        controller.GetComponent<ControllerPanel5Dop>().enabled = true;
    }
}
