using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMover : MonoBehaviour
{
    public AudioSource audioSource;
    private int i;
    private int f;
    private bool lvl4;
    public GameObject scndButton;
    public GameObject thrdButton;
    public GameObject scndTrig;
    public GameObject thrdTrig;
    public enum triggers
    {
        birinci,
        ikinci
    }
    public triggers currenttrigger;
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level4")
        {
            lvl4 = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ChangeButtonPosition();
        }
    }

    private void ChangeButtonPosition()
    {
        if (currenttrigger == triggers.birinci && i<2)
        {
            thrdButton.SetActive(true);
            thrdTrig.SetActive(true);
            scndButton.SetActive(false);
            scndTrig.SetActive(false);
            f++;
            if (f < 2)
            {
                audioSource.Play();
            }
            if (lvl4)
            {
                i++;
            }

        }
        if (currenttrigger == triggers.ikinci && i<2)
        {
            thrdButton.SetActive(false);
            thrdTrig.SetActive(false);
            scndButton.SetActive(true);
            scndTrig.SetActive(true);
            if (lvl4)
            {
                i++;
            }
        }

    }
}
