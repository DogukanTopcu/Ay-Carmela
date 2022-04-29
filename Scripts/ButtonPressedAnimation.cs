using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressedAnimation : MonoBehaviour
{
    GameObject mainCam;
    Animator anim;
    AudioSource audioSource;
    bool isEnter;
    private void Awake()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera");
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") isEnter = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isEnter = false;
        }
    }
    private void Update()
    {
        if (isEnter && Input.GetKeyDown(KeyCode.E))
        {
            mainCam.GetComponent<CameraManager>().enabled = !mainCam.GetComponent<CameraManager>().enabled;
            mainCam.transform.parent.gameObject.GetComponent<CharacterMove>().enabled = !mainCam.transform.parent.gameObject.GetComponent<CharacterMove>().enabled;
            if (GetComponent<LevelChanger>() != null)
            {
                GetComponent<LevelChanger>().ChangeLevel();
            }
            audioSource.PlayDelayed(0.2f);
            anim.SetTrigger("pressed");
        }
    }
}
