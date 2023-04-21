/*
*   Oscar Forra Carbonell
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGameObject : MonoBehaviour
{
    [SerializeField] float _xRotationsPerMinute = 1f;
    [SerializeField] float _yRotationPerMinute = 1f;
    [SerializeField] float _zRotationPerMinute = 1f;

    // Update is called once per frame
    void Update()
    {
        // Degrees per frame ^-1 = seconds frame^-1 / seconds minute ^-1 * degrees rotation ^-1 * rotation per minute ^-1
        float xDegreesPerFrame = Time.deltaTime / 60 * 360 * _xRotationsPerMinute;
        transform.RotateAround(transform.position,transform.right,xDegreesPerFrame);
        float yDegreesPerFrame = Time.deltaTime / 60 * 360 * _yRotationPerMinute;
        transform.RotateAround(transform.position,transform.up,yDegreesPerFrame);
        float zDegreesPerFrame = Time.deltaTime / 60 * 360 * _zRotationPerMinute;
        transform.RotateAround(transform.position,transform.forward,zDegreesPerFrame);
    }
}
