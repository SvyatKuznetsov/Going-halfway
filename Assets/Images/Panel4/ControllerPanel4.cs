using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class ControllerPanel4 : MonoBehaviour
{
    public GameObject[] words;
    public GameObject[] person;
    public GameObject[] v1_person;
    public GameObject[] v2_person;
    public GameObject[] v1_words;
    public GameObject personStart;
    public GameObject zzz;
    public GameObject canvasLeaf;
    public GameObject canvasButtons;
    public GameObject eye;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject bgWithBranch;
    public GameObject bgMain;
    public GameObject cameraBg;
    public GameObject cameraBg2;
    public GameObject handBranch;
    public GameObject handBranch2;
    public GameObject elkaBack;
    public GameObject belkaBack;
    public GameObject drawingCanvas;
    public GameObject readyButton;
    public Sprite spriteHandPen;
    public Sprite spriteElkaReady;
    public Sprite spriteBelkaReady;
    public Sprite spriteBelkaReady2;
    public GameObject leftWayButton;
    public GameObject rightWayButton;

    private int count = 0;
    private float time = 0;
    private bool show = true;
    private GameObject word;
    private bool startTimer = false;
    private bool startedAnim = false;
    private bool endeddAnim = false;
    private bool animPlaying = false;

    private bool pic1 = false;
    private bool pic2 = false;

    private void ShowWord()
    {
        startTimer = false;
        show = true;
        zzz.SetActive(false);

        if (count == 0)
        {
            word = words[0];
            person[0].SetActive(true);
            personStart.SetActive(false);
        }
        else if (count == 1)
        {
            words[0].GetComponent<Animation>().Play("UnshowWord");
            person[0].SetActive(false);
            person[1].SetActive(true);
            show = false;
            ++count;
        }
        else if (count == 2)
        {
            person[1].SetActive(false);
            person[2].SetActive(true);
            word = words[1];
        }
        else if (count == 3)
        {
            word = words[2];
        }
        else if (count == 4)
        {
            words[1].GetComponent<Animation>().Play("UnshowWord");
            words[2].GetComponent<Animation>().Play("UnshowWord");
            person[2].SetActive(false);
            person[3].SetActive(true);
            show = false;
            ++count;
            startTimer = true;
        }
        else if (count == 5)
        {
            canvasLeaf.SetActive(true);
            gameObject.GetComponent<ControllerPanel4>().enabled = false;
            show = false;
        }
        else if (count == 6)
        {
            words[3].GetComponent<Animation>().Play("UnshowWord");
            person[4].SetActive(false);
            person[3].SetActive(true);
            show = false;
            ++count;
        }
        else if (count == 7)
        {
            gameObject.GetComponent<ControllerPanel4>().enabled = false;
            canvasButtons.SetActive(true);
            show = false;
            ++count;
        }
        else if (count == 9)
        {
            person[3].SetActive(false);
            person[5].SetActive(true);
            word = words[4];
        }
        else if (count == 10)
        {
            words[4].GetComponent<Animation>().Play("UnshowWord");
            person[5].SetActive(false);
            person[6].SetActive(true);
            button1.SetActive(true);
            button1.GetComponent<Animation>().Play("ButtonAppearance");
            gameObject.GetComponent<ControllerPanel4>().enabled = false;
            show = false;
            ++count;
        }
        else if (count == 11)
        {
            person[6].SetActive(false);
            person[7].SetActive(true);
            button2.SetActive(false);
            show = false;
            ++count;
        }
        else if (count == 13)
        {
            gameObject.GetComponent<ControllerPanel4>().enabled = false;
            words[5].GetComponent<Animation>().Play("UnshowWord");
            button2.SetActive(false);
            person[7].SetActive(false);
            person[8].SetActive(true);
            button3.SetActive(true);
            button3.GetComponent<Animation>().Play("ButtonAppearance");
            button4.SetActive(true);
            button4.GetComponent<Animation>().Play("ButtonAppearance");
            show = false;
            ++count;
        }

        if (PlayerPrefs.GetInt("Choice2") == 1)
        {
            if (count == 15)
            {
                words[6].GetComponent<Animation>().Play("UnshowWord");
                person[9].SetActive(false);
                v1_person[0].SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 16)
            {
                v1_person[0].SetActive(false);
                v1_person[1].SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 17)
            {
                v1_person[1].SetActive(false);
                v1_person[2].SetActive(true);
                bgMain.SetActive(false);
                bgWithBranch.SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 18)
            {
                v1_person[2].SetActive(false);
                v1_person[3].SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 19)
            {
                v1_person[3].SetActive(false);
                cameraBg.GetComponent<Animation>().Play("movePenUp");
                show = false;
                ++count;
            }
            else if (count == 20)
            {
                word = v1_words[0];
                handBranch.SetActive(true);
            }
            else if (count == 21)
            {
                v1_words[0].GetComponent<Animation>().Play("UnshowWord");
                elkaBack.SetActive(true);
                drawingCanvas.SetActive(true);
                gameObject.GetComponent<ControllerPanel4>().enabled = false;
                readyButton.SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 23)
            {
                word = v1_words[1];
            }
            else if (count == 24)
            {
                word = v1_words[2];
            }
            else if (count == 25)
            {
                word = v1_words[3];
            }
            else if (count == 26)
            {
                v1_words[1].GetComponent<Animation>().Play("UnshowWord");
                v1_words[2].GetComponent<Animation>().Play("UnshowWord");
                v1_words[3].GetComponent<Animation>().Play("UnshowWord");
                word = v1_words[4];
            }
            else if (count == 27)
            {
                v1_words[4].GetComponent<Animation>().Play("UnshowWord");
                belkaBack.SetActive(true);
                drawingCanvas.SetActive(true);
                drawingCanvas.transform.GetChild(0).gameObject.SetActive(true);
                cameraBg2.GetComponent<Image>().sprite = spriteBelkaReady2;
                gameObject.GetComponent<ControllerPanel4>().enabled = false;
                cameraBg.SetActive(true);
                cameraBg2.SetActive(false);
                readyButton.SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 29)
            {
                word = v1_words[5];
            }
            else if (count == 30)
            {
                word = v1_words[6];
            }
            else if (count == 31)
            {
                word = v1_words[7];
            }
            else if (count == 32)
            {
                v1_words[5].GetComponent<Animation>().Play("UnshowWord");
                v1_words[6].GetComponent<Animation>().Play("UnshowWord");
                v1_words[7].GetComponent<Animation>().Play("UnshowWord");
                handBranch2.SetActive(false);
                cameraBg2.GetComponent<Animation>().Play("movePenDown");
                person[10].SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 33)
            {
                person[10].SetActive(false);
                person[11].SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 34)
            {
                person[11].SetActive(false);
                person[12].SetActive(true);
                word = words[7];
            }
            else if (count == 35)
            {
                words[7].GetComponent<Animation>().Play("UnshowWord");
                person[12].SetActive(false);
                person[13].SetActive(true);
                word = words[8];
            }
            else if (count == 36)
            {
                words[8].GetComponent<Animation>().Play("UnshowWord");
                person[13].SetActive(false);
                person[14].SetActive(true);
                word = words[9];
            }
            else if (count == 37)
            {
                person[14].GetComponent<Animation>().Play("moveLastPersonRight");
                words[9].GetComponent<Animation>().Play("moveLastWordLeft");
                leftWayButton.SetActive(true);
                leftWayButton.GetComponent<Animation>().Play("moveLeftWayRight");
                rightWayButton.SetActive(true);
                rightWayButton.GetComponent<Animation>().Play("moveRightWayLeft");
                show = false;
                ++count;
            }
        }
        else if (PlayerPrefs.GetInt("Choice2") == 2)
        {
            if (count == 15)
            {
                words[6].GetComponent<Animation>().Play("UnshowWord");
                person[9].SetActive(false);
                v2_person[0].SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 16)
            {
                v2_person[0].SetActive(false);
                v2_person[1].SetActive(true);
                show = false;
                count = 19;
            }
            else if (count == 19)
            {
                v2_person[1].SetActive(false);
                cameraBg.GetComponent<Animation>().Play("movePenUp");
                show = false;
                ++count;
            }
            else if (count == 20)
            {
                word = v1_words[0];
                handBranch.SetActive(true);
                handBranch.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = spriteHandPen;
                handBranch2.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = spriteHandPen;
            }
            else if (count == 21)
            {
                cameraBg2.GetComponent<Image>().sprite = spriteElkaReady;
                v1_words[0].GetComponent<Animation>().Play("UnshowWord");
                elkaBack.SetActive(true);
                drawingCanvas.SetActive(true);
                gameObject.GetComponent<ControllerPanel4>().enabled = false;
                readyButton.SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 23)
            {
                word = v1_words[1];
            }
            else if (count == 24)
            {
                word = v1_words[2];
            }
            else if (count == 25)
            {
                word = v1_words[3];
            }
            else if (count == 26)
            {
                v1_words[1].GetComponent<Animation>().Play("UnshowWord");
                v1_words[2].GetComponent<Animation>().Play("UnshowWord");
                v1_words[3].GetComponent<Animation>().Play("UnshowWord");
                word = v1_words[4];
            }
            else if (count == 27)
            {
                v1_words[4].GetComponent<Animation>().Play("UnshowWord");
                belkaBack.SetActive(true);
                cameraBg.SetActive(true);
                cameraBg2.SetActive(false);
                readyButton.SetActive(true);
                drawingCanvas.SetActive(true);
                cameraBg2.GetComponent<Image>().sprite = spriteBelkaReady;
                drawingCanvas.transform.GetChild(0).gameObject.SetActive(true);
                gameObject.GetComponent<ControllerPanel4>().enabled = false;
                show = false;
                ++count;
            }
            else if (count == 29)
            {
                word = v1_words[5];
            }
            else if (count == 30)
            {
                word = v1_words[6];
            }
            else if (count == 31)
            {
                word = v1_words[7];
            }
            else if (count == 32)
            {
                v1_words[5].GetComponent<Animation>().Play("UnshowWord");
                v1_words[6].GetComponent<Animation>().Play("UnshowWord");
                v1_words[7].GetComponent<Animation>().Play("UnshowWord");
                handBranch2.SetActive(false);
                cameraBg2.GetComponent<Animation>().Play("movePenDown");
                person[10].SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 33)
            {
                person[10].SetActive(false);
                person[11].SetActive(true);
                show = false;
                ++count;
            }
            else if (count == 34)
            {
                person[11].SetActive(false);
                person[12].SetActive(true);
                word = words[7];
            }
            else if (count == 35)
            {
                words[7].GetComponent<Animation>().Play("UnshowWord");
                person[12].SetActive(false);
                person[13].SetActive(true);
                word = words[8];
            }
            else if (count == 36)
            {
                words[8].GetComponent<Animation>().Play("UnshowWord");
                person[13].SetActive(false);
                person[14].SetActive(true);
                word = words[9];
            }
            else if (count == 37)
            {
                person[14].GetComponent<Animation>().Play("moveLastPersonRight");
                words[9].GetComponent<Animation>().Play("moveLastWordLeft");
                leftWayButton.SetActive(true);
                leftWayButton.GetComponent<Animation>().Play("moveLeftWayRight");
                rightWayButton.SetActive(true);
                rightWayButton.GetComponent<Animation>().Play("moveRightWayLeft");
                show = false;
                ++count;
            }
        }

        if (show && count < 38)
        {
            word.SetActive(true);
            word.GetComponent<Animation>().Play("WordAppearance 1");
            ++count;
        }
    }
    
    private void Update()
    {
        if (startTimer)
        {
            time += Time.deltaTime;
            if (time >= 5)
            {
                zzz.SetActive(true);
                zzz.GetComponent<Animation>().Play("zzz");
                startTimer = false;
            }
        }
        
        if (startedAnim)
        {
            animPlaying = true;
            if (!eye.GetComponent<Animation>().isPlaying)
            {
                endeddAnim = true;
                startedAnim = false;
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

    public void LoadLevel5Main()
    {
        Application.LoadLevel("Panel5Main");
    }
    
    public void LoadLevel5Dop()
    {
        PlayerPrefs.SetInt("Panel5Dop", 1);
        Application.LoadLevel("Panel5Dop");
    }

    public void RecognizeFirstPicture()
    {
        count = 23;
        readyButton.SetActive(false);
        cameraBg.SetActive(false);
        cameraBg2.SetActive(true);
        elkaBack.SetActive(false);
        gameObject.GetComponent<ControllerPanel4>().enabled = true;
    }
    
    public void RecognizeSecondPicture()
    {
        count = 29;
        readyButton.SetActive(false);
        cameraBg.SetActive(false);
        cameraBg2.SetActive(true);
        belkaBack.SetActive(false);
        gameObject.GetComponent<ControllerPanel4>().enabled = true;
    }

    public void ForReadyButton()
    {
        if (!pic1 && !pic2)
        {
            pic1 = true;
        }
        else if (pic1 && !pic2)
        {
            pic2 = true;
        }
    }

    public void ForButton1()
    {
        button2.SetActive(true);
        ++count;
    }

    public void ForButton2()
    {
        person[6].SetActive(false);
        person[7].SetActive(true);
        gameObject.GetComponent<ControllerPanel4>().enabled = true;
        word = words[5];
        word.SetActive(true);
        word.GetComponent<Animation>().Play("WordAppearance 1");
        button2.GetComponent<Button>().enabled = false;
        ++count;
    }

    public void ForButton4()
    {
        person[8].SetActive(false);
        person[9].SetActive(true);
        gameObject.GetComponent<ControllerPanel4>().enabled = true;
        word = words[6];
        word.SetActive(true);
        word.GetComponent<Animation>().Play("WordAppearance 1");
        ++count;
    }

    public void ChangeCountTo6()
    {
        gameObject.GetComponent<ControllerPanel4>().enabled = true;
        count = 6;
        person[3].SetActive(false);
        person[4].SetActive(true);
        word = words[3];
        word.SetActive(true);
        word.GetComponent<Animation>().Play("WordAppearance 1");
    }

    public void EyeButton()
    {
        eye.GetComponent<Button>().enabled = false;
        eye.GetComponent<Animation>().Play("eye_moving");
        ++count;
        gameObject.GetComponent<ControllerPanel4>().enabled = true;
    }
}
