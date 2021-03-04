using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyB : MonoBehaviour
{
    public GameObject ClickAnimation;

    void Update()
    {
        if (Input.GetButtonDown("BKey"))
        {
            ClickAnimation.GetComponent<Animator>().Play("YDOT01_press");
        }
    }
}
