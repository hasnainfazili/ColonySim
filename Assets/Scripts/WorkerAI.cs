using System;
using UnityEngine;
using UnityEngine.AI;

public class WorkerAI : MonoBehaviour
{
    protected Worker worker;
    private NavMeshAgent workerAgent;
    //TEMP For testing
    public Transform RestAreaTransform;
    protected bool hasReachedResource = false;
    
    private void Start()
    {
        workerAgent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        hasReachedResource = HasReachedResource();
    }

    public void AssignedToResource(Transform resource)
    {
        workerAgent.SetDestination(resource.position);
    }

    public void RemovedFromResource()
    {
        workerAgent.SetDestination(RestAreaTransform.position);
    }

    public bool HasReachedResource()
    {
        hasReachedResource = workerAgent.isStopped && !workerAgent.hasPath;
        return hasReachedResource;
    }
    public Worker GetWorker()
    {
        return worker;
    }

    public WorkerType GetWorkerType()
    {
        return worker.type;
    }
}