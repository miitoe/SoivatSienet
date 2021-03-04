using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKeypressO : MonoBehaviour
{
    public ParticleSystem particles;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            print("O key is held down");
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            particles.Stop();
            print("O key is up");
        }

    }
}
