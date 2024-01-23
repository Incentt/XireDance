using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject playText;
    public AudioSource theMusic;
    public bool startGame;
    public int score;
    public int HitNote;
    public int MissNote;
    public GameObject miss, bad, cool, great, perfect;
    
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            startGame = true;
            playText.SetActive(false);
        }
    }
    public void noteHit()
    {
        HitNote += 1;
    }
    public void noteMiss()
    {
        MissNote += 1;
    }
}
