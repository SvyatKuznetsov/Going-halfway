using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordControllerPart2 : MonoBehaviour
{
    public GameObject[] words;
    public GameObject[] words11;
    public GameObject[] words12;
    public GameObject[] words21;
    public GameObject[] words22;
    public GameObject[] person1;
    public GameObject[] person2;
    public GameObject[] ulitka1;
    public GameObject[] ulitka2;
    public GameObject dumayuButton;
    public GameObject neDumayuButton;
    public GameObject bgStart;
    public GameObject bgEnd;
    public GameObject bgBlur;
    public GameObject flashingArrow;
    public GameObject pen;
    public GameObject nextLevel;

    private int count = 0;
    private bool choice11 = false;
    private bool choice12 = false;
    private bool choice21 = false;
    private bool choice22 = false;
    private bool isFirstChoiceActive = false;
    private bool isSecondChoiceActive = false;
    private bool startedFirstAnim = false;
    private bool endedFirstAnim = false;
    private bool startedSecondAnim = false;
    private bool endedSecondAnim = false;
    private bool animPlaying = false;
    private WordAppearanceController _appearance;
    private GameObject word;
    private bool show = true;

    private void Awake()
    {
        _appearance = gameObject.GetComponent<WordAppearanceController>();
    }

    void ShowWord()
    {
        show = true;
        if (choice11)
        {
            if (count == 1)
            {
                word = words11[1];
                person1[0].SetActive(false);
                person1[1].SetActive(true);
            }
            else if (count == 2)
            {
                words11[0].GetComponent<Animation>().Play("UnshowWord");
                words11[1].GetComponent<Animation>().Play("UnshowWord");
                person1[1].SetActive(false);
                ulitka1[0].SetActive(false);
                person2[3].SetActive(true);
                ulitka2[1].SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 3)
            {
                person2[3].GetComponent<Animation>().Play("moveDown");
                startedFirstAnim = true;
                show = false;
                ++count;
            }
            else if (count == 4)
            {
                word = words[0];
            }
            else if (count == 5)
            {
                words[0].GetComponent<Animation>().Play("UnshowWord");
                person2[3].GetComponent<Animation>().Play("moveUp");
                startedSecondAnim = true;
                show = false;
                ++count;
            }
            else if (count == 6)
            {
                word = words[1];
            }
            else if (count == 7)
            {
                word = words[2];
            }
            else if (count == 8)
            {
                person2[3].SetActive(false);
                ulitka2[1].SetActive(false);
                person2[4].SetActive(true);
                ulitka2[2].SetActive(true);
                dumayuButton.SetActive(true);
                neDumayuButton.SetActive(true);
                words[1].GetComponent<Animation>().Play("UnshowWord");
                words[2].GetComponent<Animation>().Play("UnshowWord");
                dumayuButton.GetComponent<Animation>().Play("WordAppearance 1");
                neDumayuButton.GetComponent<Animation>().Play("WordAppearance 1");
                isSecondChoiceActive = true;
                show = false;
                ++count;
            }
            
            if (choice21)
            {
                if (count == 10)
                {
                    startedFirstAnim = true;
                    words21[0].GetComponent<Animation>().Play("UnshowWord");
                    pen.SetActive(true);
                    pen.GetComponent<Animation>().Play("movePenUp");
                    person1[4].SetActive(false);
                    person1[5].SetActive(true);
                    show = false;
                    ++count;
                }
                else if (count == 11)
                {
                    startedSecondAnim = true;
                    pen.GetComponent<Animation>().Play("movePenDown");
                    show = false;
                    ++count;
                }
                else if (count == 12)
                {
                    word = words21[1];
                }
                else if (count == 13)
                {
                    person1[5].SetActive(false);
                    person1[6].SetActive(true);
                    ulitka1[2].SetActive(false);
                    ulitka1[4].SetActive(true);
                    words21[1].GetComponent<Animation>().Play("UnshowWord");
                    word = words21[2];
                }
                else if (count == 14)
                {
                    words21[2].GetComponent<Animation>().Play("UnshowWord");
                    person1[6].SetActive(false);
                    person1[7].SetActive(true);
                    word = words21[3];
                }
                else if (count == 15)
                {
                    words21[3].GetComponent<Animation>().Play("UnshowWord");
                    person1[7].SetActive(false);
                    person1[8].SetActive(true);
                    show = false;
                    ++count;
                }
                else if (count == 16)
                {
                    person1[8].SetActive(false);
                    ulitka1[4].SetActive(false);
                    person1[9].SetActive(true);
                    ulitka1[5].SetActive(true);
                    word = words21[4];
                }
                else if (count == 17)
                {
                    word = words21[5];
                }
                else if (count == 18)
                {
                    words21[4].GetComponent<Animation>().Play("UnshowWord");
                    words21[5].GetComponent<Animation>().Play("UnshowWord");
                    person1[9].SetActive(false);
                    person1[10].SetActive(true);
                    show = false;
                    ++count;
                }
                else if (count == 19)
                {
                    pen.GetComponent<Animation>().Play("movePenUp");
                    person1[10].SetActive(false);
                    person1[11].SetActive(true);
                    pen.GetComponent<Animation>().Play("PenAppearance");
                    show = false;
                    ++count;
                }
                else if (count == 20)
                {
                    pen.GetComponent<Animation>().Play("movePenRight");
                    show = false;
                    ++count;
                }
                else if (count == 21)
                {
                    person1[11].SetActive(false);
                    person1[12].SetActive(true);
                    ulitka1[5].SetActive(false);
                    ulitka1[6].SetActive(true);
                    word = words21[6];
                }
                else if (count == 22)
                {
                    word = words21[7];
                }
                else if (count == 23)
                {
                    words21[6].GetComponent<Animation>().Play("UnshowWord");
                    words21[7].GetComponent<Animation>().Play("UnshowWord");
                    person1[12].SetActive(false);
                    person1[13].SetActive(true);
                    ulitka1[6].SetActive(false);
                    ulitka1[7].SetActive(true);
                    word = words21[8];
                }
                else if (count == 24)
                {
                    word = words21[9];
                }
                else if (count == 25)
                {
                    words21[8].GetComponent<Animation>().Play("UnshowWord");
                    words21[9].GetComponent<Animation>().Play("UnshowWord");
                    person1[13].SetActive(false);
                    person1[14].SetActive(true);
                    ulitka1[7].SetActive(false);
                    ulitka1[8].SetActive(true);
                    word = words21[10];
                }
                else if (count == 26)
                {
                    person1[14].SetActive(false);
                    ulitka1[8].SetActive(false);
                    person2[10].SetActive(true);
                    ulitka2[7].SetActive(true);
                    words21[10].GetComponent<Animation>().Play("UnshowWord");
                    word = words[3];
                }
                else if (count == 27)
                {
                    words[3].GetComponent<Animation>().Play("UnshowWord");
                    ulitka2[7].GetComponent<Animation>().Play("moveRight");
                    person2[10].GetComponent<Animation>().Play("moveLeft");
                    bgStart.SetActive(false);
                    bgEnd.SetActive(true);
                    bgBlur.SetActive(false);
                    person2[11].SetActive(true);
                    show = false;
                    ++count;
                }
                else if (count == 28)
                {
                    person2[12].SetActive(true);
                    person2[11].SetActive(false);
                    flashingArrow.SetActive(true);
                    word = words[4];
                    nextLevel.SetActive(true);
                    gameObject.GetComponent<WordControllerPart2>().enabled = false;
                }
            }
            else if (choice22)
            {
                if (count == 9)
                {
                    show = false;
                    ++count;
                }
                else if (count == 10)
                {
                    words22[0].GetComponent<Animation>().Play("UnshowWord");
                    show = false;
                    person2[5].SetActive(false);
                    person2[6].SetActive(true);
                    ++count;
                }
                else if (count == 11)
                {
                    word = words22[1];
                }
                else if (count == 12)
                {
                    ulitka2[3].SetActive(false);
                    ulitka2[4].SetActive(true);
                    words22[1].GetComponent<Animation>().Play("UnshowWord");
                    word = words22[2];
                }
                else if (count == 13)
                {
                    ulitka2[4].SetActive(false);
                    ulitka2[5].SetActive(true);
                    person2[6].SetActive(false);
                    person2[7].SetActive(true);
                    words22[2].GetComponent<Animation>().Play("UnshowWord");
                    word = words22[3];
                }
                else if (count == 14)
                {
                    person2[7].SetActive(false);
                    person2[8].SetActive(true);
                    words22[3].GetComponent<Animation>().Play("UnshowWord");
                    word = words22[4];
                }
                else if (count == 15)
                {
                    person2[8].SetActive(false);
                    ulitka2[5].SetActive(false);
                    person2[9].SetActive(true);
                    ulitka2[6].SetActive(true);
                    words22[4].GetComponent<Animation>().Play("UnshowWord");
                    word = words22[5];
                }
                else if (count == 16)
                {
                    person2[9].SetActive(false);
                    ulitka2[6].SetActive(false);
                    person2[10].SetActive(true);
                    ulitka2[7].SetActive(true);
                    words22[5].GetComponent<Animation>().Play("UnshowWord");
                    word = words[3];
                }
                else if (count == 17)
                {
                    words[3].GetComponent<Animation>().Play("UnshowWord");
                    ulitka2[7].GetComponent<Animation>().Play("moveRight");
                    person2[10].GetComponent<Animation>().Play("moveLeft");
                    bgStart.SetActive(false);
                    bgEnd.SetActive(true);
                    bgBlur.SetActive(false);
                    person2[11].SetActive(true);
                    show = false;
                    ++count;
                }
                else if (count == 18)
                {
                    person2[12].SetActive(true);
                    person2[11].SetActive(false);
                    flashingArrow.SetActive(true);
                    word = words[4];
                    nextLevel.SetActive(true);
                    gameObject.GetComponent<WordControllerPart2>().enabled = false;
                }
            }
        }
        else if (choice12)
        {
            if (count == 1)
            {
                words12[0].GetComponent<Animation>().Play("UnshowWord");
                word = words12[1];
                person2[0].SetActive(false);
                person2[1].SetActive(true);
            }
            else if (count == 2)
            {
                words12[1].GetComponent<Animation>().Play("UnshowWord");
                person2[1].SetActive(false);
                person2[2].SetActive(true);
                word = words12[2];
            }
            else if (count == 3)
            {
                word = words12[3];
            }
            else if (count == 4)
            {
                words12[2].GetComponent<Animation>().Play("UnshowWord");
                words12[3].GetComponent<Animation>().Play("UnshowWord");
                word = words12[4];
                person2[2].SetActive(false);
                person2[3].SetActive(true);
                ulitka2[0].SetActive(false);
                ulitka2[1].SetActive(true);
            }
            else if (count == 5)
            {
                words12[4].GetComponent<Animation>().Play("UnshowWord");
                person2[3].GetComponent<Animation>().Play("moveDown");
                startedFirstAnim = true;
                show = false;
                ++count;
            }
            else if (count == 6)
            {
                word = words[0];
            }
            else if (count == 7)
            {
                words[0].GetComponent<Animation>().Play("UnshowWord");
                person2[3].GetComponent<Animation>().Play("moveUp");
                startedSecondAnim = true;
                show = false;
                ++count;
            }
            else if (count == 8)
            {
                word = words[1];
            }
            else if (count == 9)
            {
                word = words[2];
            }
            else if (count == 10)
            {
                person2[3].SetActive(false);
                ulitka2[1].SetActive(false);
                person2[4].SetActive(true);
                ulitka2[2].SetActive(true);
                dumayuButton.SetActive(true);
                neDumayuButton.SetActive(true);
                words[1].GetComponent<Animation>().Play("UnshowWord");
                words[2].GetComponent<Animation>().Play("UnshowWord");
                dumayuButton.GetComponent<Animation>().Play("WordAppearance 1");
                neDumayuButton.GetComponent<Animation>().Play("WordAppearance 1");
                isSecondChoiceActive = true;
                show = false;
                ++count;
            }

            if (choice21)
            {
                if (count == 12)
                {
                    startedFirstAnim = true;
                    words21[0].GetComponent<Animation>().Play("UnshowWord");
                    pen.SetActive(true);
                    pen.GetComponent<Animation>().Play("movePenUp");
                    person1[4].SetActive(false);
                    person1[5].SetActive(true);
                    show = false;
                    ++count;
                }
                else if (count == 13)
                {
                    startedSecondAnim = true;
                    pen.GetComponent<Animation>().Play("movePenDown");
                    show = false;
                    ++count;
                }
                else if (count == 14)
                {
                    word = words21[1];
                }
                else if (count == 15)
                {
                    person1[5].SetActive(false);
                    person1[6].SetActive(true);
                    ulitka1[2].SetActive(false);
                    ulitka1[4].SetActive(true);
                    words21[1].GetComponent<Animation>().Play("UnshowWord");
                    word = words21[2];
                }
                else if (count == 16)
                {
                    words21[2].GetComponent<Animation>().Play("UnshowWord");
                    person1[6].SetActive(false);
                    person1[7].SetActive(true);
                    word = words21[3];
                }
                else if (count == 17)
                {
                    words21[3].GetComponent<Animation>().Play("UnshowWord");
                    person1[7].SetActive(false);
                    person1[8].SetActive(true);
                    show = false;
                    ++count;
                }
                else if (count == 18)
                {
                    person1[8].SetActive(false);
                    ulitka1[4].SetActive(false);
                    person1[9].SetActive(true);
                    ulitka1[5].SetActive(true);
                    word = words21[4];
                }
                else if (count == 19)
                {
                    word = words21[5];
                }
                else if (count == 20)
                {
                    words21[4].GetComponent<Animation>().Play("UnshowWord");
                    words21[5].GetComponent<Animation>().Play("UnshowWord");
                    person1[9].SetActive(false);
                    person1[10].SetActive(true);
                    show = false;
                    ++count;
                }
                else if (count == 21)
                {
                    pen.GetComponent<Animation>().Play("movePenUp");
                    person1[10].SetActive(false);
                    person1[11].SetActive(true);
                    pen.GetComponent<Animation>().Play("PenAppearance");
                    show = false;
                    ++count;
                }
                else if (count == 22)
                {
                    pen.GetComponent<Animation>().Play("movePenRight");
                    show = false;
                    ++count;
                }
                else if (count == 23)
                {
                    person1[11].SetActive(false);
                    person1[12].SetActive(true);
                    ulitka1[5].SetActive(false);
                    ulitka1[6].SetActive(true);
                    word = words21[6];
                }
                else if (count == 24)
                {
                    word = words21[7];
                }
                else if (count == 25)
                {
                    words21[6].GetComponent<Animation>().Play("UnshowWord");
                    words21[7].GetComponent<Animation>().Play("UnshowWord");
                    person1[12].SetActive(false);
                    person1[13].SetActive(true);
                    ulitka1[6].SetActive(false);
                    ulitka1[7].SetActive(true);
                    word = words21[8];
                }
                else if (count == 26)
                {
                    word = words21[9];
                }
                else if (count == 27)
                {
                    words21[8].GetComponent<Animation>().Play("UnshowWord");
                    words21[9].GetComponent<Animation>().Play("UnshowWord");
                    person1[13].SetActive(false);
                    person1[14].SetActive(true);
                    ulitka1[7].SetActive(false);
                    ulitka1[8].SetActive(true);
                    word = words21[10];
                }
                else if (count == 28)
                {
                    person1[14].SetActive(false);
                    ulitka1[8].SetActive(false);
                    person2[10].SetActive(true);
                    ulitka2[7].SetActive(true);
                    words21[10].GetComponent<Animation>().Play("UnshowWord");
                    word = words[3];
                }
                else if (count == 29)
                {
                    words[3].GetComponent<Animation>().Play("UnshowWord");
                    ulitka2[7].GetComponent<Animation>().Play("moveRight");
                    person2[10].GetComponent<Animation>().Play("moveLeft");
                    bgStart.SetActive(false);
                    bgEnd.SetActive(true);
                    bgBlur.SetActive(false);
                    person2[11].SetActive(true);
                    show = false;
                    ++count;
                }
                else if (count == 30)
                {
                    person2[12].SetActive(true);
                    person2[11].SetActive(false);
                    flashingArrow.SetActive(true);
                    word = words[4];
                    nextLevel.SetActive(true);
                    gameObject.GetComponent<WordControllerPart2>().enabled = false;
                }
            }
            else if (choice22)
            {
                if (count == 10)
                {
                    show = false;
                    ++count;
                }
                else if (count == 12)
                {
                    words22[0].GetComponent<Animation>().Play("UnshowWord");
                    show = false;
                    person2[5].SetActive(false);
                    person2[6].SetActive(true);
                    ++count;
                }
                else if (count == 13)
                {
                    word = words22[1];
                }
                else if (count == 14)
                {
                    ulitka2[3].SetActive(false);
                    ulitka2[4].SetActive(true);
                    words22[1].GetComponent<Animation>().Play("UnshowWord");
                    word = words22[2];
                }
                else if (count == 15)
                {
                    ulitka2[4].SetActive(false);
                    ulitka2[5].SetActive(true);
                    person2[6].SetActive(false);
                    person2[7].SetActive(true);
                    words22[2].GetComponent<Animation>().Play("UnshowWord");
                    word = words22[3];
                }
                else if (count == 16)
                {
                    person2[7].SetActive(false);
                    person2[8].SetActive(true);
                    words22[3].GetComponent<Animation>().Play("UnshowWord");
                    word = words22[4];
                }
                else if (count == 17)
                {
                    person2[8].SetActive(false);
                    ulitka2[5].SetActive(false);
                    person2[9].SetActive(true);
                    ulitka2[6].SetActive(true);
                    words22[4].GetComponent<Animation>().Play("UnshowWord");
                    word = words22[5];
                }
                else if (count == 18)
                {
                    person2[9].SetActive(false);
                    ulitka2[6].SetActive(false);
                    person2[10].SetActive(true);
                    ulitka2[7].SetActive(true);
                    words22[5].GetComponent<Animation>().Play("UnshowWord");
                    word = words[3];
                }
                else if (count == 19)
                {
                    words[3].GetComponent<Animation>().Play("UnshowWord");
                    ulitka2[7].GetComponent<Animation>().Play("moveRight");
                    person2[10].GetComponent<Animation>().Play("moveLeft");
                    bgStart.SetActive(false);
                    bgEnd.SetActive(true);
                    bgBlur.SetActive(false);
                    person2[11].SetActive(true);
                    show = false;
                    ++count;
                }
                else if (count == 20)
                {
                    person2[12].SetActive(true);
                    person2[11].SetActive(false);
                    flashingArrow.SetActive(true);
                    word = words[4];
                    nextLevel.SetActive(true);
                    gameObject.GetComponent<WordControllerPart2>().enabled = false;
                }
            }
        }

        if (show && count < 31)
        {
            word.SetActive(true);
            word.GetComponent<Animation>().Play("WordAppearance 1");
            ++count;
        }
    }
    
    void Update()
    {
        if (!isFirstChoiceActive && !isSecondChoiceActive && _appearance.endScript)
        {
            if (startedFirstAnim || startedSecondAnim)
            {
                animPlaying = true;
                if (!person2[3].GetComponent<Animation>().isPlaying && !pen.GetComponent<Animation>().isPlaying)
                {
                    if (startedFirstAnim)
                    {
                        endedFirstAnim = true;
                        startedFirstAnim = false;
                    }
                    
                    if (startedSecondAnim)
                    {
                        endedSecondAnim = true;
                        startedSecondAnim = false;
                    }
                    
                    animPlaying = false;
                }
            }

            if (!animPlaying)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log(count);
                    ShowWord();
                }
            }
        }
    }
    
    public void ChangeFirstChoiceVar()
    {
        isFirstChoiceActive = false;
    }
    
    public void ChangeSecondChoiceVar()
    {
        isSecondChoiceActive = false;
    }

    public void SetChoice11()
    {
        choice11 = true;
        words11[0].SetActive(true);
        words11[0].GetComponent<Animation>().Play("WordAppearance 1");
        ++count;
    }
    
    public void SetChoice12()
    {
        choice12 = true;
        words12[0].SetActive(true);
        words12[0].GetComponent<Animation>().Play("WordAppearance 1");
        ++count;
    }
    
    public void SetChoice21()
    {
        choice21 = true;
        person2[4].SetActive(false);
        ulitka2[2].SetActive(false);
        person1[4].SetActive(true);
        ulitka1[2].SetActive(true);
        words21[0].SetActive(true);
        words21[0].GetComponent<Animation>().Play("WordAppearance 1");
        ++count;
    }
    
    public void SetChoice22()
    {
        choice22 = true;
        words22[0].SetActive(true);
        words22[0].GetComponent<Animation>().Play("WordAppearance 1");
        ++count;
    }
    
    public void SaveFirstChoice1()
    {
        PlayerPrefs.SetInt("Choice1", 1);
    }
    
    public void SaveFirstChoice2()
    {
        PlayerPrefs.SetInt("Choice1", 2);
    }
    
    public void SaveSecondChoice1()
    {
        PlayerPrefs.SetInt("Choice2", 1);
    }
    
    public void SaveSecondChoice2()
    {
        PlayerPrefs.SetInt("Choice2", 2);
    }
}
