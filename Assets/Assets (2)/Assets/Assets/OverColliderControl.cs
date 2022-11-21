using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OverColliderControl : MonoBehaviour
{
    public bool isInRange = false;
    public GameObject overColliderPicture;
    public float timeee=0;
    public float counter = 0.0f;
    int i = 0;
    public GameObject scoreRemove1;
    public GameObject scoreRemove2;
    public GameObject overCollider;
    MergeFruit merge;

    void Start()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        isInRange = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
    }

    private MergeFruit GetMerge()
    {
        return merge;
    }

    void Update()
    {
        if (isInRange)
        {
            timeee += Time.deltaTime;
        }
        else
        {
            timeee = 0;
        }

        if (timeee > 1)
        {
            overColliderPicture.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, counter);
        }
        else
        {
            overColliderPicture.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
        }

        if (timeee > 5)
        {
               SceneManager.LoadScene("GameOver1");
        }
        Opacity();
    }
    public void Opacity()
    {
        if (i == 0)
        {
            counter = counter + 0.01f;
            if (counter >= 0.5f)
            {
                i = 1;
            }
        }
        else if (i == 1)
        {
            counter = counter - 0.01f;
            if (counter <= 0.0f)
            {
                i = 0;
            }
        }
    }
}
