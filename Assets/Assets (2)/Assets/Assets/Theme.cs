using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Theme : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject themePanel;
    public Sprite[] fruits;
    public Sprite[] billards;
    public Sprite[] planets;
    public Sprite[] balls;
    public Sprite[] backGround;
    public GameObject bg;

    void Start() 
    {
        if(ColliderRemove.clonesTheme[0].GetComponent<SpriteRenderer>().sprite == fruits[0])
        {
            bg.GetComponent<SpriteRenderer>().sprite = backGround[0];
        }
        if (ColliderRemove.clonesTheme[0].GetComponent<SpriteRenderer>().sprite == billards[0])
        {
            bg.GetComponent<SpriteRenderer>().sprite = backGround[1];
        }
        if (ColliderRemove.clonesTheme[0].GetComponent<SpriteRenderer>().sprite == planets[0])
        {
            bg.GetComponent<SpriteRenderer>().sprite = backGround[2];
        }
        if (ColliderRemove.clonesTheme[0].GetComponent<SpriteRenderer>().sprite == balls[0])
        {
            bg.GetComponent<SpriteRenderer>().sprite = backGround[3];
        }
    }

    void Update()
    {
       
    }

    public void PauseButton()
    {
        if(pausePanel.activeSelf == false)
        {
            PauseGame();
            ButtonSound.play();
            pausePanel.SetActive(true);
        }
        else if(pausePanel.activeSelf == true)
        {
            ResumeGame();
            ButtonSound.play();
            pausePanel.SetActive(false);
        }

    }
    public void ThemeButton()
    {
        pausePanel.SetActive(false);
        themePanel.SetActive(true);
    }

    public void ChangeTheme_Fruit()
    {
        ButtonSound.play();
        for (int i = 0; i < 100; i++)
        {
            if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_A(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = fruits[0];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_B(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = fruits[1];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_C(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = fruits[2];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_D(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = fruits[3];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_E(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = fruits[4];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_F(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = fruits[5];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_G(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = fruits[6];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_H(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = fruits[7];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_I(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = fruits[8];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_J(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = fruits[9];
            }
        }
        for (int i = 0; i < 10; i++)
        {
            ColliderRemove.clonesTheme[i].GetComponent<SpriteRenderer>().sprite = fruits[i];
        }
        bg.GetComponent<SpriteRenderer>().sprite = backGround[0];

        themePanel.SetActive(false);
        ResumeGame();
    }
    public void ChangeTheme_Billard()
    {
        ButtonSound.play();
        for (int i = 0; i < 100; i++)
        {
            if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_A(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = billards[0];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_B(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = billards[1];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_C(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = billards[2];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_D(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = billards[3];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_E(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = billards[4];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_F(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = billards[5];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_G(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = billards[6];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_H(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = billards[7];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_I(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = billards[8];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_J(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = billards[9];
            }
        }
        for (int i = 0; i < 10; i++)
        {
            ColliderRemove.clonesTheme[i].GetComponent<SpriteRenderer>().sprite = billards[i];
        }
        bg.GetComponent<SpriteRenderer>().sprite = backGround[1];
        themePanel.SetActive(false);
        ResumeGame();
    }
    public void ChangeTheme_Plantes()
    {
        ButtonSound.play();
        for (int i = 0; i < 100; i++)
        {
            if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_A(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = planets[0];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_B(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = planets[1];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_C(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = planets[2];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_D(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = planets[3];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_E(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = planets[4];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_F(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = planets[5];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_G(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = planets[6];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_H(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = planets[7];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_I(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = planets[8];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_J(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = planets[9];
            }
        }
        for (int i = 0; i < 10; i++)
        {
            ColliderRemove.clonesTheme[i].GetComponent<SpriteRenderer>().sprite = planets[i];
        }

        bg.GetComponent<SpriteRenderer>().sprite = backGround[2];
        themePanel.SetActive(false);
        ResumeGame();
    }
    public void ChangeTheme_Balls()
    {
        ButtonSound.play();
        for (int i = 0; i < 100; i++)
        {
            if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_A(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = balls[0];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_B(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = balls[1];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_C(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = balls[2];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_D(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = balls[3];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_E(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = balls[4];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_F(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = balls[5];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_G(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = balls[6];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_H(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = balls[7];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_I(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = balls[8];
            }
            else if (MergeFruit.Clones[i] != null && MergeFruit.Clones[i].name == "Fruit_J(Clone)")
            {
                MergeFruit.Clones[i].GetComponent<SpriteRenderer>().sprite = balls[9];
            }
        }
        for (int i = 0; i < 10; i++)
        {
            ColliderRemove.clonesTheme[i].GetComponent<SpriteRenderer>().sprite = balls[i];
        }

        bg.GetComponent<SpriteRenderer>().sprite = backGround[3];
        themePanel.SetActive(false);
        ResumeGame();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
