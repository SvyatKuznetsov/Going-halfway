using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPanel5Main : MonoBehaviour
{
    public GameObject[] person;
    public GameObject flashing;
    public GameObject canvasButton;
    public GameObject report;
    
    private int count = 0;

    private void ShowWord()
    {
        if (count == 0)
        {
            person[0].SetActive(false);
            person[1].transform.GetChild(0).gameObject.SetActive(true);
            flashing.SetActive(true);
            flashing.transform.GetChild(0).gameObject.GetComponent<Animation>().Play("flashing_element");
            canvasButton.SetActive(true);
            gameObject.GetComponent<ControllerPanel5Main>().enabled = false;
        }
        else if (count == 1)
        {
            report.SetActive(false);
            Invoke(nameof(EnableCameraMover), 0.1f);
        }

        if (count < 2)
        {
            ++count;
        }
    }

    private void EnableCameraMover()
    {
        gameObject.GetComponent<CameraMover>().enabled = true;
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(count);
            ShowWord();
        }
    }

    public void LoadMenu()
    {
        Destroy(GameObject.Find("Menu Manager"));
        Application.LoadLevel("Menu");
    }
}
