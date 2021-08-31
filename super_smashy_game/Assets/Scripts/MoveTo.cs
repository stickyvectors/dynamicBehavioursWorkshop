using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public Transform goal;
    NavMeshAgent agent;
    Vector3 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                mousePosition = hit.point;
            }
            Debug.Log("LMB PRESSED!");
        }
        if (Input.GetMouseButtonUp(0))
        {           
            agent.SetDestination(mousePosition);
        }
    }
}
