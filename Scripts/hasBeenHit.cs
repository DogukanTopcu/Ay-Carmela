using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hasBeenHit : MonoBehaviour
{
    public AudioSource audioSource;
    int f;
    int i;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet" && i<1)
        {
            Invoke("ChangeLevel", 10);
            Ses();
            i++;
        }
    }
    public void ChangeLevel()
    {
        SceneManager.LoadScene(0);
        GameManager.sceneNumber++;
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
