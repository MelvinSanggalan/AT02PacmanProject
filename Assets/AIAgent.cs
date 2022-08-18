using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIAgent : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform target;


    private void Awake()
    {
        TryGetComponent(out agent);
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
