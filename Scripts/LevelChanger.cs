using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public GameObject theEnd;

    public void ChangeLevel()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            GameObject.FindGameObjectWithTag("lvl1").GetComponent<lvl1>().Ses();
            Invoke("CL", 16f);
        }
        else
        {
            Invoke("CL", 1.5f);
        }
    }
    public void CL()
    {
                if (SceneManager.GetActiveScene().name == "Level5")
        {
            StartCoroutine(theEndFunction());
        }
        else
        {
            SceneManager.LoadScene(0);
            GameManager.sceneNumber++;
        }
    }
    IEnumerator theEndFunction()
    {
        theEnd.SetActive(true);
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(0);
        GameManager.sceneNumber++;
    }
}
