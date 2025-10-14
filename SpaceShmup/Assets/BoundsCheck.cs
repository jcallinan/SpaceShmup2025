using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 
/// Keeps the GameObject within the screen bounds
/// Note: This script assumes the camera is orthographic
/// </summary>

public class BoundsCheck : MonoBehaviour
{
    [Header("Dynamic")]
    public float camWidth;
    public float camHeight;

    void Awake()
    {
        camHeight = Camera.main.orthographicSize;
        camWidth = camHeight * Camera.main.aspect;
    }
    

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = transform.position;
        // restrict x to the camera bounds
        if (pos.x > camWidth)
        {
            pos.x = camWidth;
        }
        if (pos.x < -camWidth)
        {
            pos.x = -camWidth;
        }
        if (pos.y > camHeight)
        {
            pos.y = camHeight;
        }
        if (pos.y < -camHeight)
        {
            pos.y = -camHeight;
        }
        transform.position = pos;
    }
}
