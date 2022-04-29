using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalscene : MonoBehaviour
{
    public GameObject gg;
    public AudioSource audioSource;
    public Transform mandm;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = transform.position + Vector3.up;
            other.gameObject.transform.LookAt(mandm);
            other.gameObject.GetComponent<CharacterMove>().enabled = !other.gameObject.GetComponent<CharacterMove>().enabled;
            other.gameObject.transform.GetChild(0).GetComponent<CameraManager>().enabled = !other.gameObject.transform.GetChild(0).GetComponent<CameraManager>().enabled;
            StartCoroutine(sc());
        }
    }
    IEnumerator sc()
    {
        yield return new WaitForSeconds(3);
        audioSource.Play();
        gg.SetActive(true);
    }
}
