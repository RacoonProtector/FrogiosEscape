using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickMovement : MonoBehaviour
{
    public NavMeshAgent agent;

    public Animator playerAnimation;
    public bool IsRunning;

    public Camera playerCamera;
      
    public GameObject targetDest;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit myRaycastHit;

            if (Physics.Raycast(myRay, out myRaycastHit))
            {
                agent.SetDestination(myRaycastHit.point);
            }
        }

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            IsRunning = false;
        }
        else
        {
            IsRunning = true;
        }

        playerAnimation.SetBool("IsRunning", IsRunning);
    }
}
