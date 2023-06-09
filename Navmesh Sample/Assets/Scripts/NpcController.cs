using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcController : MonoBehaviour
{
    private NavMeshAgent _agent;
    [SerializeField] private Transform targetDestination;
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();  
    }

    void Update()  

    {
        _agent.SetDestination(targetDestination.position);

    }
}
