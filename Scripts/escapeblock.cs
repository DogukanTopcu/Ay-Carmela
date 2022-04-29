using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escapeblock : MonoBehaviour
{
    public AudioSource audioSource;
    int f;
    GameObject button;
    GameObject Player;
    bool hasExit = false;
    private void Awake()
    {
        Ses();
    }

    public void Ses()
    {
        f++;
        if (f < 2)
        {
            audioSource.PlayDelayed(0.5f);
        }
    }
    private void Update()
    {
        if (button == null)
        {
            button = GameObject.FindGameObjectWithTag("Button");
        }
        if (hasExit)
        {
            Player.transform.position = button.transform.position - Vector3.forward;
            hasExit = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player = other.gameObject;
            print("Gaçma len");
            hasExit = true;
        }
    }
}