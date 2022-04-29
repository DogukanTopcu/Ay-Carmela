using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private CharacterController controller;


    Vector3 velocity;
    [SerializeField] private float gravity = -9.81f;

    private int speedScale;
    void Start()
    {

        speedScale = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
        if (SceneManager.GetActiveScene().name == "Level8")
        {
            speedScale = -1;
        }
        else
        {
            speedScale = 1;
        }
    }


    private void MovePlayer()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 25f;
        }
        else
        {
            speed = 20f;
        }

        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime * speedScale);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
