using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform followTarget;
    public float followSpeed = 5;
    private Vector3 _offset;

    void Start()
    {
        _offset = followTarget.position - transform.position;
    }
    
    void Update()
    {
        if (followTarget)
        {
            transform.position = followTarget.position - _offset;
        }    
    }
}
