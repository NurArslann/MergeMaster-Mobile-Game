using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public Sprite SoundOn;
    public Sprite SoundOff;
    public GameObject SoundImage;
    void Start()
    {

    }

    public void PlayGame()
    {
        ButtonSound.play();
        MergeFruit.score_count = 0;
        SceneManager.LoadScene("Game");
        ReklamManager.timeLeft = 10.0f;
        ReklamManager.interstitialReklam();
        Time.timeScale = 1;
    }
    public void Menu()
    {
        ButtonSound.play();
        SceneManager.LoadScene("Menu");
    }
    public void SoundOnOff()
    {
        if(AudioListener.pause == false)
        {
            AudioListener.pause = true;
            SoundImage.GetComponent<Image>().sprite = SoundOff;
        }
        else
        {
            AudioListener.pause = false;
            SoundImage.GetComponent<Image>().sprite = SoundOn;
        }
    }
}
