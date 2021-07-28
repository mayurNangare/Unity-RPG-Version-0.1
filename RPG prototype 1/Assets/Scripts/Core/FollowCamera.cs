using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.XR;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 0.5f;

   
    private void LateUpdate()
    {
        transform.position = target.position;
    }
} //class
