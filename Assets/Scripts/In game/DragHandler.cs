using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject fountain;
    public GameObject fountainButton;
    public GameObject personPanel;
    public GameObject personMask;
    public GameObject kostil;
    public GameObject leaf1;
    public GameObject leaf2;
    public GameObject leaf3;
    public GameObject flashingLeaf;
    public GameObject handBranch;

    private bool _isFountainActive = false;
    private bool _isPersonPanelActive = false;
    private bool _isChangedActiveLeaf = false;
    private Vector3 _newPos;
    private WordAppearanceController _wordAppearanceController;
    private ControllerPanel4 _controllerPanel4;

    private void Awake()
    {
        _wordAppearanceController = FindObjectOfType<WordAppearanceController>();
        _controllerPanel4 = FindObjectOfType<ControllerPanel4>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (gameObject.name != "Controller")
        {
            transform.position = _newPos;
        }
    }

    private void Update()
    {
        if (gameObject.name != "leaf_down")
        {
            if (!leaf1.activeInHierarchy && !leaf2.activeInHierarchy && !leaf3.activeInHierarchy)
            {
                if (!_isChangedActiveLeaf)
                {
                    _wordAppearanceController.ChangeActiveLeaf();
                    _isChangedActiveLeaf = true;
                }
            }
        
            if (_isFountainActive && gameObject.name == "Controller")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    fountain.SetActive(false);
                    _isFountainActive = false;
                    fountainButton.GetComponent<Button>().enabled = false;
                    _wordAppearanceController.isFountainActive = false;
                }
            }
        }
        
        /*if (_isPersonPanelActive && gameObject.name == "Controller" && _wordAppearanceController.endWords)
        {
            if (Input.GetMouseButtonDown(0))
            {
                _wordAppearanceController.words[8].SetActive(false);
                _wordAppearanceController.words[9].SetActive(false);
                _wordAppearanceController.endWords = false;
                personMask.SetActive(false);
                personPanel.SetActive(false);
                _isPersonPanelActive = false;
                kostil.SetActive(false);
            }
        }*/
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (gameObject.name != "Controller")
        {
            transform.position = Input.mousePosition;
            flashingLeaf.SetActive(false);
            flashingLeaf.GetComponent<Animation>().enabled = false;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (gameObject.name != "Controller")
        {
            _newPos = Input.mousePosition;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BorderLeafStart"))
        {
            StartAnim();
        }
    }

    public void ChangeVarForFountain()
    {
        if (_isFountainActive)
        {
            _isFountainActive = false;
        }
        else
        {
            _isFountainActive = true;
        }
    }
    
    public void ChangeVarForPersonPanel()
    {
        if (_isPersonPanelActive)
        {
            _isPersonPanelActive = false;
        }
        else
        {
            _isPersonPanelActive = true;
        }
    }

    private void UnSettingActive()
    {
        gameObject.SetActive(false);
    }

    private void StartAnim()
    {
        if (gameObject.name == "leaf_down")
        {
            _controllerPanel4.ChangeCountTo6();
        }
        gameObject.transform.GetChild(0).GetComponent<Animation>().Play("HidingObj");
        Invoke(nameof(UnSettingActive), 1.1f); 
        
        //fountain.SetActive(true);
        //fountain.GetComponent<Button>().enabled = true;
    }
}
