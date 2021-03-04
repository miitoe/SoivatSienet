using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyH : MonoBehaviour
{
    public GameObject theNPC3;

    void Update()
    {
        if (Input.GetButtonDown("HKey"))
        {
            theNPC3.GetComponent<Animator>().Play("YDOT03_press");
        }
    }
}
