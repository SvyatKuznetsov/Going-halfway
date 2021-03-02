using System;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private Slider sliderMusicMenu;
    [SerializeField] private Slider sliderMusicCards;
    [SerializeField] private GameObject rusMenu;
    [SerializeField] private GameObject engMenu;
    [SerializeField] private GameObject rusCards;
    [SerializeField] private GameObject engCards;
    private float _volumeSound;
    private string _language;

    private void Start()
    {
        LoadSettings();
        AudioListener.volume = _volumeSound;
        sliderMusicMenu.value = _volumeSound;
        sliderMusicCards.value = _volumeSound;
        SelectLanguage(_language);
    }

    private void Update()
    {
        SetSoundVolume(sliderMusicMenu.value);
        SetSoundVolume(sliderMusicCards.value);
        AudioListener.volume = _volumeSound;
        SelectLanguage(_language);
    }

    public void SetMusicVolumeInMenu()
    {
        sliderMusicMenu.value = sliderMusicCards.value;
    }
    
    public void SetMusicVolumeInCards()
    {
        sliderMusicCards.value = sliderMusicMenu.value;
    }

    private void SelectLanguage(string lang)
    {
        switch (lang)
        {
            case "rus":
                rusMenu.SetActive(true);
                rusCards.SetActive(true);
                engMenu.SetActive(false);
                engCards.SetActive(false);
                break;
            case "eng":
                engMenu.SetActive(true);
                engCards.SetActive(true);
                rusMenu.SetActive(false);
                rusCards.SetActive(false);
                break;
        }
    }
    
    public void SetLanguage(string lang)
    {
        _language = lang;
        SaveSettings();
    }
    
    private void SetSoundVolume(float volume)
    {
        _volumeSound = volume;
        SaveSettings();
    }

    private void SaveSettings()
    {
        PlayerPrefs.SetString("language", _language);
        PlayerPrefs.SetFloat("musicLevel", _volumeSound);
    }

    private void LoadSettings()
    {
        _language = PlayerPrefs.GetString("language", "rus");
        _volumeSound = PlayerPrefs.GetFloat("musicLevel", 1f);
    }
}
