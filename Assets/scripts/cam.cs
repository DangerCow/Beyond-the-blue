using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public float speedM;
    public bool pause = false;

    private void Start()
    {
        Cursor.visible = false;
    }

    void FixedUpdate()
    {
        if (pause == false)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");
            //Cursor.lockState = CursorLockMode.Locked;
        } else { Cursor.lockState = CursorLockMode.None; Cursor.visible = true; }

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        if (Input.GetKeyDown(KeyCode.Escape)) { pause = !pause; if (!false) {
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = false;
            } }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, speedM * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speedM * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speedM * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speedM * Time.deltaTime, 0, 0);
        }
    }
}
