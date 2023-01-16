using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float Speed;
    public float zoom;

    void Start()
    {
        
    }
    void Update()
    {
        
        if (transform.position.z > -1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -1);
        }
        float xAxisValue = Input.GetAxis("Horizontal") * Speed;
        float yAxisValue = Input.GetAxis("Vertical") * Speed;
     

        transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y + yAxisValue, transform.position.z + Input.GetAxisRaw("Mouse ScrollWheel") * zoom);
    }
}
