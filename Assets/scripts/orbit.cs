using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{

    public Transform body;
    public float speed;
    public float inital_angal;

    public bool rotates = false;

    // Use this for initialization
    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) { rotates = !rotates;  } // togoles rotates 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rotates == true) { transform.RotateAround(body.position, Vector3.up, inital_angal + speed); } // rotates object around body at speed
    }
}
