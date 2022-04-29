using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl7 : MonoBehaviour
{
    public AudioSource audioSource;
    int f;
    public void Ses()
    {
        f++;
        if (f < 2)
        {
            audioSource.PlayDelayed(0.5f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Ses();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
