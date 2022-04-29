using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int sceneNumber = 1;
    public Text StartOrRestartText;
    void Start()
    {
        
        if (sceneNumber == 1)
        {
            StartOrRestartText.GetComponent<Text>().text = "Başla";
        }
        else if (sceneNumber == 2)
        {
            StartOrRestartText.GetComponent<Text>().text = "Başla (Devam Et Dinleme Onları)";
        }
        else if (sceneNumber == 3)
        {
            StartOrRestartText.GetComponent<Text>().text = "Başla (Butonlara Basmaya Devam Et)";
        }
        else if (sceneNumber == 6)
        {
            StartOrRestartText.GetComponent<Text>().text = "Başla (İnanma Devam Et)";
        }
        else if (sceneNumber == 10)
        {
            StartOrRestartText.GetComponent<Text>().text = "Başla (Bul Onları)";
        }
        else
        {
            StartOrRestartText.GetComponent<Text>().text = "Devam Et";
        }
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void PressStart()
    {
        if (sceneNumber > 1)
        {
            SceneManager.LoadScene(sceneNumber);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        sceneNumber = 0;
#else 
        Application.Quit();
        sceneNumber = 0;
#endif
    }
}
