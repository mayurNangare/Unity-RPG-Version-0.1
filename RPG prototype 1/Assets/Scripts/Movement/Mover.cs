using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{

    private void Update()
   {
       if (Input.GetMouseButton(0))
       {
           MoveToCursor();
       }

       UpdateAnimator();
   }
   
    public void MoveToCursor()
   {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // shoots a ray from the main camera origin;
        RaycastHit hit; // gets the hit point;
        bool hasHit = Physics.Raycast(ray, out hit); // returns a bool if the ray hits a collider;

       if (hasHit)
       {
           GetComponent<NavMeshAgent>().destination = hit.point; // if true then sets the players position to mouse position;
       }
   } // method

    private void UpdateAnimator()
    {
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
        GetComponent<Animator>().SetFloat("forwardSpeed",speed);
    }
    
} // class
