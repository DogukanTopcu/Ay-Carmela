using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraManager : MonoBehaviour
{
    private float mouseSensitivity = 1000f;
    [SerializeField] private Transform playerBody;
    private float xRotation = 0f;
    private int scale;
    void Start()
    {
        scale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level8") scale = -1;
        else scale = 1;
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime * scale;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime * scale;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 40f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
