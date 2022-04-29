using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonspawner : MonoBehaviour
{
    public GameObject button;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") Instantiate(button,transform.position + new Vector3(0,-58,0),Quaternion.identity);
    }
}
