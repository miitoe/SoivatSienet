using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyO : MonoBehaviour
{
    public GameObject ClickAnimation;

    void Update()
    {
        if (Input.GetButtonDown("OKey"))
        {
            ClickAnimation.GetComponent<Animator>().Play("BDOT05_press");
        }
        if (Input.GetButtonUp("OKey"))
        {
            ClickAnimation.GetComponent<Animator>().Play("BDOT05_idle");
        }
    }
}
