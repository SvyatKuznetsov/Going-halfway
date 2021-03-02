using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearanceController : MonoBehaviour
{
    public GameObject element11;
    public GameObject element10;
    public GameObject camera;
    public GameObject wordController;
    public GameObject nextLevelButton;
    
    public bool endAll = false;
    public bool startDialog = false;

    private float time = 0;
    
    private bool el1 = false;
    private bool el2 = false;
    private bool el3 = false;
    private bool el4 = false;
    private bool el5 = false;
    private bool el6 = false;
    private bool el7 = false;
    private bool el8 = false;
    private bool el9 = false;
    private bool firstTime = false;
    private bool el10 = false;
    private bool person1 = false;
    private bool person2 = false;
    private bool person3 = false;
    private bool animOlen = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(1);
        if (other.gameObject.name == "1" && !el1)
        {
            el1 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "2" && !el2)
        {
            el2 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "3" && !el3)
        {
            el3 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "4" && !el4)
        {
            el4 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "5" && !el5)
        {
            el5 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "6" && !el6)
        {
            el6 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "7" && !el7)
        {
            el7 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "8" && !el8)
        {
            el8 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "9" && !el9)
        {
            el9 = true;
            PlayAnimation(other);
            endAll = true;
        }
        else if (other.gameObject.name == "Person1" && !person1)
        {
            person1 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "Person2" && !person2)
        {
            person2 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "Person3" && !person3)
        {
            person3 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "anim_olen" && !animOlen)
        {
            animOlen = true;
            PlayAnimation(other);
        }
    }

    private void Update()
    {
        if (endAll)
        {
            gameObject.GetComponent<CameraMover>().enabled = false;
            if (time < 1.0f && !firstTime)
            {
                time += Time.deltaTime;
            }
            else if (time > 1.0f && !firstTime)
            {
                element10.transform.GetChild(0).gameObject.SetActive(true);
                element10.GetComponent<Animation>().Play("WordAppearance 1");
                time = 0;
                firstTime = true;
            }
            else if (time < 3.0f && firstTime)
            {
                time += Time.deltaTime;
            }
            else if (time > 3.0f && firstTime)
            {
                element11.transform.GetChild(0).gameObject.SetActive(true);
                element11.GetComponent<Animation>().Play("MoveUlitka");
                camera.gameObject.GetComponent<Animation>().Play("Shake");
                
                //camera.gameObject.transform.GetChild(0).gameObject.GetComponent<Animation>().Play("Shake");
                endAll = false;
                Invoke(nameof(ChangeBool), 1.5f);
            }
        }
    }

    public void NextLevel()
    {
        Application.LoadLevel("Panel3");
    }
    
    public void LoadLevel4()
    {
        Application.LoadLevel("Panel4");
    }
    
    private void ChangeBool()
    {
        startDialog = true;
        nextLevelButton.SetActive(true);
    }

    private void PlayAnimation(Collider other)
    {
        other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        other.GetComponent<Animation>().Play("WordAppearance 1");
    }
    
    public void LoadMenu()
    {
        Destroy(GameObject.Find("Menu Manager"));
        Application.LoadLevel("Menu");
    }
}
