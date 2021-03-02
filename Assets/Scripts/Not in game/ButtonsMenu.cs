using UnityEngine;

public class ButtonsMenu : MonoBehaviour
{
  private bool _settings;
  private int _attachmentLevel;
  
  [SerializeField] GameObject menu;
  [SerializeField] GameObject cardsMenu;
  [SerializeField] GameObject card;
  [SerializeField] GameObject buttons;
  [SerializeField] GameObject otherButtons;
  [SerializeField] GameObject settingsCanvas;

  public void chooseWhatToUnset(int num)
  {
    switch (num)
    {
      case 0:
        Invoke(nameof(UnSettingMenu), 1f);
        break;
      case 1:
        Invoke(nameof(UnSettingCardsMenu), 1f);
        break;
      case 2:
        Invoke(nameof(UnSettingCard), 1f);
        break;
    }
  }
  
  private void UnSettingMenu()
  {
    menu.SetActive(false);
  }
  
  private void UnSettingCardsMenu()
  {
    cardsMenu.SetActive(false);
  }
  
  private void UnSettingCard()
  {
    card.SetActive(false);
  }
  
  public void setSettings(bool s)
  {
    _settings = s;
  }
  
  public void setAttachmentLevel(int level)
  {
    _attachmentLevel = level;
  }
  
  void UnSettingActive()
  {
    if (_settings)
      settingsCanvas.SetActive(false);
    buttons.SetActive(false);
    if (_attachmentLevel == 1)
    {
      buttons.SetActive(false);
      otherButtons.SetActive(false);
    }
    else if (_attachmentLevel == 2)
    {
      otherButtons.SetActive(false);
    }
  }

  public void PlayAnimationClip(string nameOfAnimation)
  {
    GetComponent<Animation>().Play(nameOfAnimation);
    Invoke(nameof(UnSettingActive), 1f);
  }
}
