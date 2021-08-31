using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{

    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;

        MoveToNextPoint();
    }

    void MoveToNextPoint()
    {
        agent.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }

    private void Update()
    {
        if(!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            MoveToNextPoint();
        }
    }
}
