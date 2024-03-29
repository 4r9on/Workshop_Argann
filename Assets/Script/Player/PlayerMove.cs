using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class PlayerMove : MonoBehaviour
{
    public LayerMask LayerMask;

    public Camera Cam;
    NavMeshAgent _agent;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            _agent.isStopped = true;
            return;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask))
        {
            _agent.isStopped = true;
            return;
        }

        _agent.isStopped = false;

        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {

            if(Physics.Raycast(ray,out hit))
            {
                _agent.SetDestination(hit.point);
            }
        }
        
    }
}
