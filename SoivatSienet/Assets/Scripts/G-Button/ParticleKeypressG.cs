using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKeypressG : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
    // }

    public ParticleSystem particles;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            print("G key is held down");
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.G))
        {
            particles.Stop();
            print("G key is up");
        }

    }
}
