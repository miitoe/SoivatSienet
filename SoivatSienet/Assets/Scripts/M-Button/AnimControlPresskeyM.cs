using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyM : MonoBehaviour
{
    public GameObject ClickAnimation;

    void Update()
    {
        if (Input.GetButtonDown("MKey"))
        {
            ClickAnimation.GetComponent<Animator>().Play("YDOT03_press");
        }
    }
}


