using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickMovement : MonoBehaviour
{
    public NavMeshAgent agent;
       public GameObject targetDest;
       void Start()
       {
          agent = GetComponent<NavMeshAgent>();
       }
       void Update()
       {
          if (!Input.GetMouseButtonDown(0)) return;
          RaycastHit hit;
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
          if (Physics.Raycast(ray, out hit, Mathf.Infinity))
          {
             targetDest.transform.position = hit.point;
             agent.SetDestination(hit.point);
          }
       }
}
