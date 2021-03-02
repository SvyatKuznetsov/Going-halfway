using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class WordAppearanceController : MonoBehaviour
{
    public GameObject[] words;
    public GameObject yes;
    public GameObject no;
    public GameObject personButton;
    public GameObject personPreButton;
    public GameObject personButton2;
    public GameObject personDark;
    public GameObject personMaskButton;
    public GameObject maskDark;
    public GameObject otherDark;
    public GameObject fountainButton;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    public GameObject obj11;
    public GameObject obj12;
    public GameObject obj13;
    public GameObject obj14;
    public GameObject blur_bg;
    public GameObject kostilll;
    public GameObject camera;
    public GameObject buttons;
    public GameObject button1;
    public GameObject button2;
    public GameObject flashingBelka;
    public GameObject flashingFountain;
    public GameObject flashingArrow;
    public bool endWords = false;
    public bool isFountainActive = false;
    public bool boolForFountainWithoutActive = true;
    public bool endScript = false;

    private int count = 0;
    private int _countOfTouches = 0;
    //private DragHandler _dragHandler;
    private bool _isLeafActive = false;
    private bool _exBool = false;
    private bool _isYesNoActive = false;
    private bool _isPersonPanelActive = false;
    private bool dopusl = false;
    private bool _isEnd = false;
    private bool _endMoving = false;
    private bool _endWords = false;
    private bool _isActivatedFountain = false;
    private AppearanceController _appearance;

    private void Awake()
    {
        //_dragHandler = FindObjectOfType<DragHandler>();
        _appearance = camera.GetComponent<AppearanceController>();
    }

    IEnumerator Wait1Sec()
    {
        yield return new WaitForSeconds(1f);
        dopusl = false;
    }

    void ShowWord(GameObject word)
    {
        if (gameObject.name == "Controller")
        {
            if (count == 2)
            {
                words[0].GetComponent<Animation>().Play("UnshowWord");
                words[1].GetComponent<Animation>().Play("UnshowWord");
                personButton.SetActive(true);
                personPreButton.SetActive(false);
            }
            else if (count == 6)
            {
                yes.SetActive(true);
                no.SetActive(true);
                _exBool = true;
                yes.GetComponent<Animation>().Play("WordAppearance 1");
                no.GetComponent<Animation>().Play("WordAppearance 1");
                _isYesNoActive = true;
                _isPersonPanelActive = true;
            }
            else if (count == 11)
            {
                words[11].GetComponent<Animation>().Play("WordAppearance 1");
            }
            else if (count == 12)
            {
                obj3.SetActive(false);
                obj4.SetActive(true);
                words[11].GetComponent<Animation>().Play("UnshowWord");
                //words[12].GetComponent<Animation>().Play("WordAppearance 1");
            }
            else if (count == 16)
            {
                obj4.SetActive(false);
                obj5.SetActive(true);
                words[12].GetComponent<Animation>().Play("UnshowWord");
                words[13].GetComponent<Animation>().Play("UnshowWord");
                words[14].GetComponent<Animation>().Play("UnshowWord");
                words[15].GetComponent<Animation>().Play("UnshowWord");
            }
            else if (count == 18)
            {
                obj5.SetActive(false);
                obj6.SetActive(true);
                _exBool = true;
                words[16].GetComponent<Animation>().Play("UnshowWord");
                words[17].GetComponent<Animation>().Play("UnshowWord");
            }
            else if (count == 19)
            {
                obj5.SetActive(true);
                obj6.SetActive(false);
                word = words[18];
            }
            else if (count == 20)
            {
                word = words[19];
            }
            else if (count == 21)
            {
                Debug.Log("olo");
                obj5.SetActive(false);
                obj7.SetActive(true);
                words[18].GetComponent<Animation>().Play("UnshowWord");
                words[19].GetComponent<Animation>().Play("UnshowWord");
                word = words[20];
                flashingArrow.SetActive(true);
                //_isEnd = true;
                camera.GetComponent<CameraMover>().enabled = true;
            }
            if (count < 22 && count != 6)
            {
                word.SetActive(true);
                word.GetComponent<Animation>().Play("WordAppearance 1");
                ++count;
            }
        }
        else if (gameObject.name == "ControllerPanel3")
        {
            bool show = true;
            word = words[count - 1];
            if (count == 22)
            {
                obj8.SetActive(true);
                blur_bg.SetActive(true);
                camera.GetComponent<CameraMover>().enabled = false;
            }
            else if (count == 25)
            {
                words[21].GetComponent<Animation>().Play("UnshowWord");
                words[22].GetComponent<Animation>().Play("UnshowWord");
                words[23].GetComponent<Animation>().Play("UnshowWord");
            }
            else if (count == 28)
            {
                words[24].GetComponent<Animation>().Play("UnshowWord");
                words[25].GetComponent<Animation>().Play("UnshowWord");
                obj9.SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 29)
            {
                words[26].GetComponent<Animation>().Play("UnshowWord");
                word = words[count - 2];
                obj9.SetActive(false);
                obj8.SetActive(false);
                obj10.SetActive(true);
                obj11.SetActive(true);
            }
            else if (count == 30)
            {
                word = words[count - 2];
            }
            else if (count == 31)
            {
                words[27].GetComponent<Animation>().Play("UnshowWord");
                words[28].GetComponent<Animation>().Play("UnshowWord");
                obj12.SetActive(true);
                obj13.SetActive(true);
                obj10.SetActive(false);
                obj11.SetActive(false);
                word = words[count - 2];
            }
            else if (count == 32)
            {
                word = words[count - 2];
                obj12.SetActive(false);
                obj13.SetActive(false);
                obj9.SetActive(true);
                obj8.SetActive(true);
            }
            else if (count == 33)
            {
                obj9.SetActive(false);
                obj12.SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 34)
            {
                obj12.SetActive(false);
                obj14.SetActive(true);
                show = false;
                buttons.SetActive(true);
                button1.GetComponent<Animation>().Play("WordAppearance 1");
                button2.GetComponent<Animation>().Play("WordAppearance 1");
                ++count;
                endScript = true;
            }
            
            if (show && count < 35)
            {
                word.SetActive(true);
                word.GetComponent<Animation>().Play("WordAppearance 1");
                ++count;
            }
        }

        /*if (!_exBool && !_endWords)
        {
            word.SetActive(true);
            word.GetComponent<Animation>().Play("WordAppearance 1");
            ++count;
            _exBool = true;
            if (count == 22)
            {
                _endWords = true;
            }
        }

        _exBool = false;*/
    }

    public void ChangeFountainBool()
    {
        if (isFountainActive)
        {
            isFountainActive = false;
        }
        else
        {
            isFountainActive = true;
            _isActivatedFountain = true;
            boolForFountainWithoutActive = false;
        }
    }

    public void EndScript()
    {
        endScript = true;
        button1.SetActive(false);
        button2.SetActive(false);
        words[29].SetActive(false);
        words[30].SetActive(false);
        obj14.SetActive(false);
        obj8.SetActive(false);
    }

    private void Update()
    {
        if (!isFountainActive && _isActivatedFountain || boolForFountainWithoutActive && !_isActivatedFountain)
        {
            if (_appearance.startDialog && !_endMoving)
            {
                _endMoving = true;
            }
            
            if (!dopusl && !_isEnd)
            {
                if (_countOfTouches == 3)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        obj2.SetActive(false);
                        obj3.SetActive(true);
                        _isPersonPanelActive = false;
                        count = 11;
                        endWords = true;
                        words[8].SetActive(false);
                        words[9].SetActive(false);
                        words[10].SetActive(false);
                        endWords = false;
                        personMaskButton.SetActive(false);
                        personButton2.SetActive(false);
                        //_dragHandler.personPanel.SetActive(false);
                        _isPersonPanelActive = false;
                        //_dragHandler.kostil.SetActive(false);
                        otherDark.SetActive(false);
                        maskDark.SetActive(false);
                        personDark.SetActive(false);
                        ++_countOfTouches;
                    }
                }
            
                if (_isLeafActive && !_isYesNoActive && !_isPersonPanelActive)
                {
                    if (gameObject.name == "Controller")
                    {
                        if (count < 22)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                Debug.Log(count);
                                ShowWord(words[count]);
                            }
                        }
                    }
                    else if (gameObject.name == "ControllerPanel3")
                    {
                        if (count == 0)
                        {
                            count = 22;
                        }

                        if (count != 35)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                Debug.Log(count);
                                ShowWord(words[count]);
                            }
                        }
                    }
                }
            }
        }
    }
    
    public void UnshowSecond4Words()
    {
        words[2].GetComponent<Animation>().Play("UnshowWord");
        words[3].GetComponent<Animation>().Play("UnshowWord");
        words[4].GetComponent<Animation>().Play("UnshowWord");
        words[5].GetComponent<Animation>().Play("UnshowWord");
        personButton.GetComponent<Button>().enabled = true;
        //fountainButton.GetComponent<Button>().enabled = true;
    }

    public void ChangeActiveLeaf()
    {
        _isLeafActive = true;
        if (gameObject.name != "ControllerPanel3")
        {
            flashingFountain.SetActive(true);
        }
    }

    public void UnsettingFountain()
    {
        flashingFountain.SetActive(false);
        flashingFountain.GetComponent<Animation>().enabled = false;
    }
    
    public void UnsettingBelka()
    {
        flashingBelka.SetActive(false);
        flashingBelka.GetComponent<Animation>().enabled = false;
    }

    public void SettingFlashingBelka()
    {
        flashingBelka.SetActive(true);
    }

    public void ChangeYesNoVar()
    {
        _isYesNoActive = false;
    }
    
    IEnumerator ShowThirdWords(GameObject word)
    {
        if (count < 9)
        {
            yield return new WaitForSeconds(1f);
            word.SetActive(true);
            word.GetComponent<Animation>().Play("WordAppearance 1");
            StartCoroutine(ShowThirdWords(words[count++]));
        }
        else
        {
            personMaskButton.GetComponent<Button>().enabled = true;
            personButton2.GetComponent<Button>().enabled = true;
            kostilll.SetActive(true);
        }
    }

    public void ShowThird2Words()
    {
        //dopusl = true;
        StartCoroutine(ShowThirdWords(words[count++]));
        StartCoroutine(Wait1Sec());
    }
    
    public void ShowFourthWord1()
    {
        count = 8;
        GameObject word = words[count++];
        words[9].SetActive(false);
        words[10].SetActive(false);
        word.SetActive(true);
        word.GetComponent<Animation>().Play("WordAppearance 1");
        ++_countOfTouches;
        personMaskButton.GetComponent<Button>().enabled = false;
    }

    public void changeColorToDark1()
    {
        //Vector4 newColor = new Vector4(50/255.0f, 50/255.0f, 50/255.0f, 1);
        //personMaskButton.GetComponent<Image>().color = newColor;
        maskDark.SetActive(true);
    }
    
    public void ShowFourthWord2()
    {
        count = 9;
        GameObject word = words[count++];
        words[8].SetActive(false);
        words[10].SetActive(false);
        word.SetActive(true);
        ++_countOfTouches;
        kostilll.SetActive(false);
    }
    
    public void changeColorToDark2()
    {
        otherDark.SetActive(true);
    }
    
    public void ShowFourthWord3()
    {
        count = 10;
        GameObject word = words[count++];
        words[8].SetActive(false);
        words[9].SetActive(false);
        word.SetActive(true);
        ++_countOfTouches;
        personButton2.GetComponent<Button>().enabled = false;
    }
    
    public void changeColorToDark3()
    {
        //Vector4 newColor = new Vector4(90/255.0f, 90/255.0f, 90/255.0f, 1);
        //personButton2.GetComponent<Image>().color = newColor;
        personDark.SetActive(true);
    }
}
