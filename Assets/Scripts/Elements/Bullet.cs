using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private bool _isMoving;
    public void Init()
    {
        StartMoving();
    }
    private void Update()
    {
        if (_isMoving)
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
    }

    private void StartMoving()
    {
        _isMoving = true;
    }

    
}
