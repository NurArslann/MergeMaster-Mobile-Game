using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MergeFruit : MonoBehaviour
{
    public static int score_count = 0;
    public static int highScrore;
    public Text highScoreText;

    //[SerializeField]
    public Text score;
    int ID;
    public GameObject MergedObject;
    public Transform Block1;
    public Transform Block2;
    public float Distance;
    public float MergeSpeed;
    public GameObject O;
    bool CanMerge;
    public static GameObject[] Clones = new GameObject[100];
    int i = 0;


    void Start()
    {
        score.GetComponents<Text>();
        highScoreText.GetComponent<Text>();

        highScrore = PlayerPrefs.GetInt("highscore", highScrore);
        highScoreText.text = highScrore.ToString();
        ID = GetInstanceID();
    }

    void Update()
    {
        printText();
        if (score_count > highScrore)
        {
            highScrore = score_count;
            highScoreText.text = "" + score;

            PlayerPrefs.SetInt("highscore", highScrore);
            PlayerPrefs.Save();
        }
    }
    private void FixedUpdate()
    {
        MoveTowards();
    }
    public void MoveTowards()
    {
        if (CanMerge)
        {
            transform.position = Vector2.MoveTowards(Block1.position, Block2.position, MergeSpeed);
            if (Vector2.Distance(Block1.position, Block2.position) < Distance)
            {
                if (ID < Block2.gameObject.GetComponent<MergeFruit>().ID) { return; }
                //Debug.Log($"SENDING MESSAGE FROM {gameObject.name} With The ID Number of{ID}");
                O = Instantiate(MergedObject, transform.position, Quaternion.identity);
                Destroy(Block2.gameObject);
                Destroy(gameObject);
                O.GetComponent<Fruit>().enabled = false;
                for (i = 0; i < 100; i++)
                {
                    if (Clones[i] == null)
                    {
                        Clones[i] = O;
                        break;
                    }
                }

            }
        }
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("Compare_A"))
        {
            if (collision.gameObject.tag == tag)
            {
                Block1 = transform;
                Block2 = collision.transform;
                CanMerge = true;
                Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
                Destroy(GetComponent<Rigidbody2D>());
                score_count = score_count + 4;
                MergeSound.play();
            }
        }
        if (collision.gameObject.CompareTag("Compare_B"))
        {
            if (collision.gameObject.tag == tag)
            {
                Block1 = transform;
                Block2 = collision.transform;
                CanMerge = true;
                Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
                Destroy(GetComponent<Rigidbody2D>());
                score_count = score_count + 8;
                MergeSound.play();
            }
        }
        if (collision.gameObject.CompareTag("Compare_C"))
        {
            if (collision.gameObject.GetComponent<SpriteRenderer>().sprite == GetComponent<SpriteRenderer>().sprite)
            {
                Block1 = transform;
                Block2 = collision.transform;
                CanMerge = true;
                Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
                Destroy(GetComponent<Rigidbody2D>());
                score_count = score_count + 16;
                MergeSound.play();
            }
        }
        if (collision.gameObject.CompareTag("Compare_D"))
        {
            if (collision.gameObject.GetComponent<SpriteRenderer>().sprite == GetComponent<SpriteRenderer>().sprite)
            {
                Block1 = transform;
                Block2 = collision.transform;
                CanMerge = true;
                Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
                Destroy(GetComponent<Rigidbody2D>());
                score_count = score_count + 32;
                MergeSound.play();
            }
        }
        if (collision.gameObject.CompareTag("Compare_E"))
        {
            if (collision.gameObject.GetComponent<SpriteRenderer>().sprite == GetComponent<SpriteRenderer>().sprite)
            {
                Block1 = transform;
                Block2 = collision.transform;
                CanMerge = true;
                Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
                Destroy(GetComponent<Rigidbody2D>());
                score_count = score_count + 64;
                MergeSound.play();
            }
        }
        if (collision.gameObject.CompareTag("Compare_F"))
        {
            if (collision.gameObject.GetComponent<SpriteRenderer>().sprite == GetComponent<SpriteRenderer>().sprite)
            {
                Block1 = transform;
                Block2 = collision.transform;
                CanMerge = true;
                Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
                Destroy(GetComponent<Rigidbody2D>());
                score_count = score_count + 128;
                MergeSound.play();
            }
        }
        if (collision.gameObject.CompareTag("Compare_G"))
        {
            if (collision.gameObject.GetComponent<SpriteRenderer>().sprite == GetComponent<SpriteRenderer>().sprite)
            {
                Block1 = transform;
                Block2 = collision.transform;
                CanMerge = true;
                Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
                Destroy(GetComponent<Rigidbody2D>());
                score_count = score_count + 256;
                MergeSound.play();
            }
        }
        if (collision.gameObject.CompareTag("Compare_H"))
        {
            if (collision.gameObject.GetComponent<SpriteRenderer>().sprite == GetComponent<SpriteRenderer>().sprite)
            {
                Block1 = transform;
                Block2 = collision.transform;
                CanMerge = true;
                Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
                Destroy(GetComponent<Rigidbody2D>());
                score_count = score_count + 512;
                MergeSound.play();
            }
        }
        if (collision.gameObject.CompareTag("Compare_I"))
        {
            if (collision.gameObject.GetComponent<SpriteRenderer>().sprite == GetComponent<SpriteRenderer>().sprite)
            {
                Block1 = transform;
                Block2 = collision.transform;
                CanMerge = true;

                Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
                Destroy(GetComponent<Rigidbody2D>());
                score_count = score_count + 1024;
                MergeSound.play();
            }
        }
       
        
    }
    private void printText()
    {
        score.text = score_count.ToString();
    }
    
}