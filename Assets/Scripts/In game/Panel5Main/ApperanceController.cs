using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApperanceController : MonoBehaviour
{
    private bool el1 = false;
    private bool el2 = false;
    private bool el4 = false;
    private bool el5 = false;
    private bool el6 = false;
    private bool el7 = false;
    private bool other1 = false;
    private bool other2 = false;
    private bool word1 = false;
    private bool word2 = false;
    private bool word3 = false;
    private bool word4 = false;
    
    private void OnTriggerEnter(Collider other)
    {
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
        else if (other.gameObject.name == "other1" && !other1)
        {
            other1 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "other2" && !other2)
        {
            other2 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "word1" && !word1)
        {
            word1 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "word2" && !word2)
        {
            word2 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "word3" && !word3)
        {
            word3 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "word4" && !word4)
        {
            word4 = true;
            PlayAnimation(other);
        }
    }
    
    private void PlayAnimation(Collider other)
    {
        other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        other.GetComponent<Animation>().Play("WordAppearance 1");
    }
}
