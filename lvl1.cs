using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl1 : MonoBehaviour
{
    AudioSource audioSource;
    int f = 0;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Ses()
    {
        f++;
        if (f<2)
        {
            audioSource.PlayDelayed(1);
        }
    }
}
