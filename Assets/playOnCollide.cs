using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playOnCollide : MonoBehaviour
{
    // Make 4 different audiosources
    public AudioSource audio;

    void OnCollisionEnter(Collision collision)
    {
        // Use PlayOneShot method
        audio.PlayOneShot(audio.clip);
    }

}
