using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedvfxmove : MonoBehaviour
{
    private GameObject player; Vector3 distance;
    public float t;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        distance = player.transform.position - transform.position;
    }

    void FixedUpdate()
    {
        float xAxis = transform.position.x;
        Vector3 targetposition = player.transform.position - distance;
        Vector3 smoothposition = Vector3.Lerp(transform.position,targetposition, t*Time.deltaTime);
        transform.position = smoothposition;
        transform.position = new Vector3(xAxis, transform.position.y, transform.position.z);
    }
}
