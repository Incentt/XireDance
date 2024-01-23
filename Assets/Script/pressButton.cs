using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressButton : MonoBehaviour
{
    private SpriteRenderer SR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public KeyCode keyPress;
    private void Start()
    {
        SR = gameObject.GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(keyPress))
        {
            SR.sprite = pressedImage;
            transform.localScale = new Vector3(0.55f, 0.55f, 1);
        }
        if (Input.GetKeyUp(keyPress))
        {
            SR.sprite = defaultImage;
            transform.localScale = new Vector3(0.5f, 0.5f, 1);

        }
    }


}
