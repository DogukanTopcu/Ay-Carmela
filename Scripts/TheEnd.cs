using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour
{
    public GameObject mainCam;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("ChangeLevel", 2);
            mainCam.GetComponent<CameraManager>().enabled = !mainCam.GetComponent<CameraManager>().enabled;
            mainCam.transform.parent.gameObject.GetComponent<CharacterMove>().enabled = !mainCam.transform.parent.gameObject.GetComponent<CharacterMove>().enabled;
        }
    }
    void ChangeLevel()
    {
        SceneManager.LoadScene(0);
        GameManager.sceneNumber++;
    }
}
