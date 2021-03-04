using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKeypressP : MonoBehaviour
{
    public ParticleSystem particles;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            print("P key is held down");
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.P))
        {
            particles.Stop();
            print("P key is up");
        }

    }
}
