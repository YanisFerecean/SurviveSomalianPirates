using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 9f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime,0,0);
    }
    private void FixedUpdate()
    {
        if(Time.time % 5 == 0)
        {
            cameraSpeed = cameraSpeed + 0.2f;
        }
    }
}
