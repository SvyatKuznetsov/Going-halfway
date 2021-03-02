using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearanceContr : MonoBehaviour
{
    private bool person4 = false;
    private bool person5 = false;
    private bool person6 = false;
    private bool person7 = false;
    private bool person8 = false;
    private bool person9 = false;
    private bool anim_olen = false;
    private bool word3 = false;
    private bool word4 = false;
    private bool word5 = false;
    private bool word8 = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "person4" && !person4)
        {
            person4 = true;
            PlayAnimation(other);
        } 
        else if (other.gameObject.name == "person5" && !person5)
        {
            person5 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "person6" && !person6)
        {
            person6 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "person7" && !person7)
        {
            person7 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "person8" && !person8)
        {
            person8 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "person9" && !person9)
        {
            person9 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "anim_olen" && !anim_olen)
        {
            anim_olen = true;
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
        else if (other.gameObject.name == "word5" && !word5)
        {
            word5 = true;
            PlayAnimation(other);
        }
        else if (other.gameObject.name == "word8" && !word8)
        {
            word8 = true;
            PlayAnimation(other);
        }
    }
    
    private void PlayAnimation(Collider other)
    {
        other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        other.GetComponent<Animation>().Play("WordAppearance 1");
    }
}
