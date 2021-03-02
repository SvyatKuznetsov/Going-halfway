using System;
using UnityEngine;
using UnityEngine.UI;

public class ColliderPhysics : MonoBehaviour
{
    public GameObject camera;
    public GameObject movingPart;
    public GameObject nextLevelButton;
    public GameObject flashingArrow;

    private float time = 0;
    private bool isShown = false;
    private bool _word3 = false;
    private bool _word4 = false;
    private bool _word5 = false;
    private bool _word6 = false;
    private bool _word7 = false;
    private bool _word8 = false;
    private bool secondShow = false;
    private bool thirdShow = false;
    private bool for6 = false;

    private void Update()
    {
        if (Math.Abs(movingPart.transform.position.y + 181f) < 0.1f)
        {
            movingPart.GetComponent<NameMoverY>().enabled = false;
            isShown = true;
        }

        if (isShown)
        {
            time += Time.deltaTime;
        }

        if (time > 0.5f)
        {
            if (!thirdShow)
            {
                flashingArrow.SetActive(true);
                flashingArrow.GetComponent<Animation>().enabled = true;
                thirdShow = true;
            }
            isShown = false;
            time = 0;
            camera.GetComponent<CameraMoverY>().enabled = true;
        }

        if (Math.Abs(camera.transform.position.y + 190.5f) < 0.01f)
        {
            //camera.GetComponent<CameraMoverY>().enabled = false;
            nextLevelButton.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) && (!secondShow || thirdShow))
        {
            flashingArrow.GetComponent<Animation>().enabled = false;
            flashingArrow.SetActive(false);
        }
    }
    
    public void LoadMenu()
    {
        Destroy(GameObject.Find("Menu Manager"));
        Application.LoadLevel("Menu");
    }
    
    public void NextLevel()
    {
        Application.LoadLevel("Panel2");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "6")
        {
            if (!for6)
            {
                if (!secondShow)
                {
                    Debug.Log("6");
                    flashingArrow.SetActive(true);
                    flashingArrow.GetComponent<Animation>().enabled = true;
                    secondShow = true;
                }
                camera.GetComponent<CameraMoverY>().enabled = false;
                movingPart.GetComponent<NameMoverY>().enabled = true;
                for6 = true;
            }
        }
        
        if (other.gameObject.name == "Word3" && !_word3)
        {
            _word3 = true;
            WordFunc(other);
        }
        else if (other.gameObject.name == "Word4" && !_word4)
        {
            _word4 = true;
            WordFunc(other);
        }
        else if (other.gameObject.name == "Word5" && !_word5)
        {
            _word5 = true;
            WordFunc(other);
        }
        else if (other.gameObject.name == "Word6" && !_word6)
        {
            _word6 = true;
            WordFunc(other);
        }
        else if (other.gameObject.name == "Word7" && !_word7)
        {
            _word7 = true;
            WordFunc(other);
        }
        else if (other.gameObject.name == "Word8" && !_word8)
        {
            _word8 = true;
            WordFunc(other);
        }
    }
    
    private void WordFunc(Collider other)
    {
        other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        other.GetComponent<Animation>().Play("WordAppearance 1");
    }
}
