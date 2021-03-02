using System;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
  public GameObject cards;

  private void Start()
  {
    cards.SetActive(false);
    DontDestroyOnLoad(gameObject);
  }
  
  public void StartGame()
  {
    gameObject.GetComponent<Settings>().enabled = false;
    Application.LoadLevel("Panel1");
  }

  public void LoadLevel1()
  {
    gameObject.GetComponent<Settings>().enabled = false;
    Application.LoadLevel("Panel1");
  }
  
  public void LoadLevel2()
  {
    gameObject.GetComponent<Settings>().enabled = false;
    Application.LoadLevel("Panel2");
  }
  
  public void LoadLevel3()
  {
    gameObject.GetComponent<Settings>().enabled = false;
    Application.LoadLevel("Panel3");
  }
  
  public void LoadLevel4()
  {
    gameObject.GetComponent<Settings>().enabled = false;
    Application.LoadLevel("Panel4");
  }
  
  public void LoadLevel5Main()
  {
    Application.LoadLevel("Panel5Main");
  }
  
  public void LoadLevel5Dop()
  {
    Application.LoadLevel("Panel5Dop");
  }
  
  public void LoadTest()
  {
    gameObject.GetComponent<Settings>().enabled = false;
    Application.LoadLevel("MultiStroke_Demo_Script");
  }
}
