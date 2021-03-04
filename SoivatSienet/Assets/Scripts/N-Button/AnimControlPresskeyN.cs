using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyN : MonoBehaviour
{
    public GameObject ClickAnimation;

    void Update()
    {
        if (Input.GetButtonDown("NKey"))
        {
            ClickAnimation.GetComponent<Animator>().Play("YDOT02_press");
        }
    }
}

