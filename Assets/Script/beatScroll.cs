using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beatScroll : MonoBehaviour
{
    public float speed = 2f;

    public KeyCode keyPress;
    private GameManager gm;
    public bool miss = false;
 
    private void Start()
    {
        gm = GameObject.FindAnyObjectByType<GameManager>();
    }
    private void Update()
    {
        if (gm.startGame)
        {
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0f);
        }
        if (transform.localPosition.y < -1)
        {
            miss = true;
        }
        if (miss)
        {
            gm.noteMiss();
            Destroy(gameObject);
        }
            if (Input.GetKeyDown(keyPress) && Mathf.Abs(transform.localPosition.y) > 1.3f)
            {
                
                if (Mathf.Abs(transform.localPosition.y) > 1.3f)
                {
                Debug.Log("miss");
                gm.miss.SetActive(true);
                gm.score += 10;
                }
                else if (Mathf.Abs(transform.localPosition.y) > 1f)
                {
                Debug.Log("bad");
                gm.bad.SetActive(true);
                gm.score += 20;
            }
                else if (Mathf.Abs(transform.localPosition.y) > 0.5f)
                {
                Debug.Log("cool");
                gm.cool.SetActive(true);
                gm.score += 30;
            }
                else if (Mathf.Abs(transform.localPosition.y) > 0.25f)
                {
                Debug.Log("great");
                gm.great.SetActive(true);
                gm.score += 40;
            }
                else if (Mathf.Abs(transform.localPosition.y) > 0.05f)
                {
                Debug.Log("perfect");
                gm.perfect.SetActive(true);
                gm.score += 50;
            }
                else if (Mathf.Abs(transform.localPosition.y) == 0f)
                {
                Debug.Log("perfect");
                gm.perfect.SetActive(true);
                gm.score += 50;
            }
                Destroy(gameObject);
            gm.noteHit();

            }
       
        

        

    }

   

}
