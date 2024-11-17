using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public bool FixedRotation = false;
    void Update()
    {
        if(FixedRotation) {
            transform.Rotate(0,50 * Time.deltaTime,0);
        } else {
            if (Input.GetButton("Fire1") || Input.GetAxis("Horizontal") != 0)
            {
                transform.Rotate(0,(-5 * Input.GetAxis("Mouse X") + (Input.GetAxis("Horizontal") * 500) * Time.deltaTime),0);
                //0,(-5 * Input.GetAxis("Mouse X") + (Input.GetAxis("Horizontal") * 500) * Time.deltaTime),0
            }
        }
    }
}