using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKeypressT : MonoBehaviour
{
    public ParticleSystem particles;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            print("T key is held down");
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            particles.Stop();
            print("T key is up");
        }

    }
}
