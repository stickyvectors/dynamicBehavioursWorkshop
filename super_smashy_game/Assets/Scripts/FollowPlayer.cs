using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public float radius = 10f;
    public float stoppingRadius = 3f;
    public NavMeshAgent agent;
    public GameObject player;

    private bool PlayerNearby = false;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radius);
        Gizmos.DrawWireSphere(transform.position, stoppingRadius);
    }

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.stoppingDistance = stoppingRadius;

        StartCoroutine(PlayerProximityRoutine());
    }

    private IEnumerator PlayerProximityRoutine()
    {
        float delay = 0.2f;
        WaitForSeconds wait = new WaitForSeconds(delay);

        while (true)
        {
            yield return wait;
            PlayerProximityCheck();
            if(PlayerNearby)
            {
                StartCoroutine(BeginFollowPlayer());
            }
        }
    }

    private void PlayerProximityCheck()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        //Debug.Log("distance: " + distance);
        if (distance < radius)
        {
            PlayerNearby = true;
            return;
        }
    }

    private IEnumerator BeginFollowPlayer()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            agent.SetDestination(player.transform.position);
        }
        
    }
    
}
