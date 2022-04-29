using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip ac;
    int f = 0;

    IEnumerator Start()
    {
        Ses();
        yield return new WaitForSeconds(7);
        audioSource.clip = ac;
        audioSource.Play();
        yield return new WaitForSeconds(14);
        GameManager.sceneNumber++;
        SceneManager.LoadScene(0);
    }

    public void Ses()
    {
        f++;
        if (f < 2)
        {
            audioSource.PlayDelayed(0.5f);
        }
    }
}
