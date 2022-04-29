using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl3 : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip cliip;
    public GameObject go;
    bool asd;
    int f = 0;
    int a = 0;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(Ses());
    }
    public GameObject door;
    public IEnumerator Ses()
    {
        f++;
        if (f < 2)
        {
            audioSource.PlayDelayed(0.5f);
            yield return new WaitForSeconds(12);
            Destroy(door);
            StartCoroutine(Ses2());
        }
    }
    public IEnumerator Ses2()
    {
        a++;
        if (a < 2)
        {
            audioSource.clip = cliip;
            yield return new WaitForSeconds(10);
            audioSource.PlayDelayed(0f);
            go.SetActive(true);
        }
    }
}
