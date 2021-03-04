using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayPresskeyG : MonoBehaviour
{

    public AudioSource cLong;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) {
            if (!cLong.isPlaying)
            {
                cLong.Play();

            }
        }
            //if (Input.GetKeyUp(KeyCode.G))
            //{ cLong.Stop();
            //}

    }
}
