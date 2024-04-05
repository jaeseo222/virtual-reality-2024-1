using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class W05_1_NavMeshAgentScript : MonoBehaviour
{
    // 목표 대상
    public Transform Target;
    NavMeshAgent Agent;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Agent.destination = Target.position;
    }
}
