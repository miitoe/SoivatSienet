using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyP : MonoBehaviour
{
    public GameObject ClickAnimation;

    void Update()
    {
        if (Input.GetButtonDown("PKey"))
        {
            ClickAnimation.GetComponent<Animator>().Play("BDOT06_press");
        }

        if (Input.GetButtonUp("PKey"))
        {
            ClickAnimation.GetComponent<Animator>().Play("BDOT06_idle");
        }
    }
}