using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl6 : MonoBehaviour
{
    public AudioSource audioSource;
    private int i = 0;
    public GameObject[] roomObjects;
    public Material[] roomMaterials;
    private GameObject mainCam;
    private void Awake()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera");
        audioSource.Play();
    }
    private void Update()
    {
        if (i == 11)
        {
            mainCam.GetComponent<CameraManager>().enabled = !mainCam.GetComponent<CameraManager>().enabled;
            mainCam.transform.parent.gameObject.GetComponent<CharacterMove>().enabled = !mainCam.transform.parent.gameObject.GetComponent<CharacterMove>().enabled;
            i++;
        }
    }
    IEnumerator Start()
    {
        if (i<5)
        {
            roomObjects[i].GetComponent<MeshRenderer>().material = roomMaterials[i];
            yield return new WaitForSeconds(0.8f);
            i++;
            StartCoroutine(Start());
        }
        else if (i>=5 && i<11)
        {
            roomObjects[i].GetComponent<MeshRenderer>().material = roomMaterials[i];
            yield return new WaitForSeconds(0.3f);
            i++;
            StartCoroutine(Start());
        }
    }
}
