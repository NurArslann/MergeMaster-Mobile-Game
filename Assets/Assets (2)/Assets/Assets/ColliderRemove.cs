using UnityEngine;
using System.Collections;
using System.Threading;
using UnityEngine.SceneManagement;
public class ColliderRemove : MonoBehaviour
{
    private static int count = 0;
    public static GameObject cloned;
    public GameObject boxcollider;
    [SerializeField]
    public GameObject[] clones;
    public static GameObject[] clonesTheme = new GameObject[10];

    public int x, i=0;

    float timeDelay = 3.0f;

    void Awake()
    {
        for(i = 0;i < 10; i++)
        {
            clonesTheme[i] = clones[i];
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount >= 1)
        {

            StartCoroutine(control());
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                x = Random.Range(0, 100);
                boxcollider.GetComponent<BoxCollider2D>().enabled = true;
                StartCoroutine(control());
                //control();

                if (count < 1)
                {
                    count++;
                    if(x < 50)
                    {
                        cloned = Instantiate(clones[0]);
                    }
                    else if(x >= 50 && x < 80)
                    {
                        cloned = Instantiate(clones[1]);
                    }
                    else if(x >= 80 && x < 95)
                    {
                        cloned = Instantiate(clones[2]);
                    }
                    else
                    {
                        cloned = Instantiate(clones[3]);
                    }
                    for (i = 0; i < 100; i++)
                    {
                        if (MergeFruit.Clones[i] == null)
                        {
                            MergeFruit.Clones[i] = cloned;
                            break;
                        }
                    }
                }


                if (Trigger.hadibe && count != 1)
                {
                    if (x < 50)
                    {
                        cloned = Instantiate(clones[0]);
                    }
                    else if (x >= 50 && x < 80)
                    {
                        cloned = Instantiate(clones[1]);
                    }
                    else if (x >= 80 && x < 95)
                    {
                        cloned = Instantiate(clones[2]);
                    }
                    else
                    {
                        cloned = Instantiate(clones[3]);
                    }
                    Trigger.hadibe = false;
                    for (i = 0; i < 100; i++)
                    {
                        if (MergeFruit.Clones[i] == null)
                        {
                            MergeFruit.Clones[i] = cloned;
                            break;
                        }
                    }
                }

                StartCoroutine(control());
                count = 2;
            }

            if (Input.touches[0].phase == TouchPhase.Ended)
            {
                boxcollider.GetComponent<BoxCollider2D>().enabled = false;
                cloned.GetComponent<Fruit>().enabled = false;
                StartCoroutine(control());
            }
        }


    }

    IEnumerator control()
    {
        yield return new WaitForSeconds(timeDelay);
    }
   
}
