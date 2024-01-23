using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float timer = 120f;
    public GameObject playText;
    public AudioSource theMusic;
    public bool startGame;
    public int score;
    public Text scoreUI;
    public int HitNote;
    public int MissNote;
    public GameObject miss, bad, cool, great, perfect;
    private bool isOnce;
    public Animator anim;
    public Text perfectText;
    public GameObject restartButt;

    public Text missCount;
    private int hitCount;
    private void Update()
    {
        if (Input.GetKeyDown("space") && isOnce == false)
        {
            startGame = true;
            playText.SetActive(false);
            theMusic.Play();
            isOnce = true;
            anim.SetBool("isPlay", true);
        }
        scoreUI.text = score.ToString();
        perfectText.text = "Hit: " + hitCount.ToString();
        missCount.text = "Miss: " + MissNote.ToString();
        if(isOnce == true)
        {
            timer -= Time.deltaTime;
            
        }
        if(timer <= 0)
        {
            restartButt.SetActive(true);
        }
        
    }
    public void noteHit()
    {
        hitCount += 1;
    }
    public void noteMiss()
    {
        MissNote += 1;
    }
}
