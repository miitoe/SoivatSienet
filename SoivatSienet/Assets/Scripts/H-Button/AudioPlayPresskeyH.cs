using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayPresskeyH : MonoBehaviour
{

    public AudioSource gLong;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (!gLong.isPlaying)
            {
                gLong.Play();

            }
        }
        //if (Input.GetKeyUp(KeyCode.H))
        //{ cLong.Stop();
        //}

    }
}
