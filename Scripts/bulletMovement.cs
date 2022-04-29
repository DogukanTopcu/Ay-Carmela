using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    private void Update()
    {
        //transform.position += transform.forward;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            print("a");
            collision.gameObject.GetComponent<Animator>().SetTrigger("shot");
        }
    }









}
