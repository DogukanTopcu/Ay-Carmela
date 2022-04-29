using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    AudioSource audioSource;
    Animator anim;
    bool isEnter;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        isEnter = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isEnter = false;
    }
    private void Update()
    {
        if (isEnter && Input.GetKeyDown(KeyCode.E) && SceneManager.GetActiveScene().name == "Level9")
        {
            anim.SetTrigger("open");
        }
        else if (isEnter && Input.GetKeyDown(KeyCode.E))
        {
            audioSource.PlayDelayed(0f);
        }
    }
}
