using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beatScroll : MonoBehaviour
{
    public float speed = 2f;
    public bool canPress;
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
     
 
        if(transform.localPosition.y < -1)
        {
            gm.noteMiss();
            gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(keyPress))
        {
            if (canPress)
            {
                
                if (Input.GetKeyDown(keyPress))
                {
                    
                    gameObject.SetActive(false);
                    if (Mathf.Abs(transform.localPosition.y) > 0.8f)
                    {
                        Debug.Log("miss");
                        gm.miss.SetActive(true);
                        gm.score += 10;
                        gm.noteMiss();
                    }
                    else if (Mathf.Abs(transform.localPosition.y) > 0.7f)
                    {
                        Debug.Log("bad");
                        gm.bad.SetActive(true);
                        gm.score += 20;
                        gm.noteHit();
                    }
                    else if (Mathf.Abs(transform.localPosition.y) > 0.5f)
                    {
                        Debug.Log("cool");
                        gm.cool.SetActive(true);
                        gm.score += 30;
                        gm.noteHit();
                    }
                    else if (Mathf.Abs(transform.localPosition.y) > 0.25f)
                    {
                        Debug.Log("great");
                        gm.great.SetActive(true);
                        gm.score += 40;
                        gm.noteHit();
                    }
                    else if (Mathf.Abs(transform.localPosition.y) > 0.05f)
                    {
                        Debug.Log("perfect");
                        gm.perfect.SetActive(true);
                        gm.score += 50;
                        gm.noteHit();
                    }
                    else
                    {
                        Debug.Log("perfect");
                        gm.perfect.SetActive(true);
                        gm.score += 50;
                        gm.noteHit();
                    }
                    
                }

            }
        }
        
        

        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("buttPress"))
        {
            canPress = true;
        }
    }

}
