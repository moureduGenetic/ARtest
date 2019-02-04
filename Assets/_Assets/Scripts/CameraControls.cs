using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    float camMovSpeed;
    float camRotSpeed;

    void Update()
    {
        //Camera controls for testing
        camMovSpeed = Time.deltaTime / 2;
        if (Input.GetKey(KeyCode.A)) { transform.Translate(-camMovSpeed, 0, 0); }
        if (Input.GetKey(KeyCode.D)) { transform.Translate(camMovSpeed, 0, 0); }
        if (Input.GetKey(KeyCode.W)) { transform.Translate(0, 0, camMovSpeed); }
        if (Input.GetKey(KeyCode.S)) { transform.Translate(0, 0, -camMovSpeed); }
        camRotSpeed = Time.deltaTime * 25;
        if (Input.GetKey(KeyCode.LeftArrow)) { transform.Rotate(0, -camRotSpeed, 0); }
        if (Input.GetKey(KeyCode.RightArrow)) { transform.Rotate(0, camRotSpeed, 0); }
        if (Input.GetKey(KeyCode.UpArrow)) { transform.Rotate(-camRotSpeed, 0, 0); }
        if (Input.GetKey(KeyCode.DownArrow)) { transform.Rotate(camRotSpeed, 0, 0); }
    }
}
