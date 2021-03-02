using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPanel5Dop : MonoBehaviour
{
    public GameObject[] persons;
    public GameObject[] words;
    public GameObject flashingArrow1;
    public GameObject flashingArrow2;
    public GameObject camera;
    public GameObject leftWayButton;
    public GameObject rightWayButton;
    
    private int count = 0;
    private GameObject word;
    private bool show = true;

    private void ShowWord()
    {
        show = true;
        
        if (count == 0)
        {
            persons[0].SetActive(false);
            persons[1].SetActive(true);
            word = words[1];
        }
        else if (count == 1)
        {
            persons[1].SetActive(false);
            persons[2].SetActive(true);
            flashingArrow1.SetActive(true);
            gameObject.GetComponent<ControllerPanel5Dop>().enabled = false;
            camera.GetComponent<CameraMover>().enabled = true;
            show = false;
            ++count;
        }
        else if (count == 2)
        {
            words[2].GetComponent<Animation>().Play("UnshowWord");
            persons[3].SetActive(false);
            persons[4].gameObject.transform.GetChild(0).gameObject.SetActive(true);
            word = words[3];
            word.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (count == 3)
        {
            words[3].GetComponent<Animation>().Play("UnshowWord");
            persons[4].SetActive(false);
            persons[5].gameObject.transform.GetChild(0).gameObject.SetActive(true);
            show = false;
            ++count;
        }
        else if (count == 4)
        {
            persons[5].SetActive(false);
            persons[6].gameObject.transform.GetChild(0).gameObject.SetActive(true);
            word = words[4];
            word.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            flashingArrow2.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Invoke(nameof(EnableCamera), 0.5f);
            gameObject.GetComponent<ControllerPanel5Dop>().enabled = false;
        }
        else if (count == 5)
        {
            persons[7].GetComponent<Animation>().Play("moveRightPerson");
            words[5].GetComponent<Animation>().Play("moveLeftWord");
            leftWayButton.SetActive(true);
            leftWayButton.GetComponent<Animation>().Play("moveLeftWay");
            rightWayButton.SetActive(true);
            rightWayButton.GetComponent<Animation>().Play("moveRightWay");
            show = false;
            ++count;
        }

        if (show && count < 6)
        {
            word.SetActive(true);
            word.GetComponent<Animation>().Play("WordAppearance 1");
            ++count;
        }
    }
    
    public void LoadLevel5Main()
    {
        Application.LoadLevel("Panel5Main");
    }
    
    public void LoadLevel5Dop()
    {
        PlayerPrefs.SetInt("Panel5Dop", 1);
        Application.LoadLevel("Panel5Dop");
    }
    
    public void LoadMenu()
    {
        Destroy(GameObject.Find("Menu Manager"));
        Application.LoadLevel("Menu");
    }

    private void EnableCamera()
    {
        camera.GetComponent<CameraMover>().enabled = true;
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(count);
            ShowWord();
        }
    }
}
