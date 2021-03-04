using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControlPresskeyT : MonoBehaviour
{
    public GameObject theNPC1;

    void Update()
    {
        if (Input.GetButtonDown("TKey"))
        {
            theNPC1.GetComponent<Animator>().Play("YDOT01_press");
        }
    }
}
