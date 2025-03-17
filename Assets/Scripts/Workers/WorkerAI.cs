using System;
using UnityEngine;
using UnityEngine.AI;

public class WorkerAI : MonoBehaviour
{
    [SerializeField] protected Worker worker;
    private NavMeshAgent workerAgent;
    //TEMP For testing
    public Transform RestAreaTransform;
    protected bool hasReachedResource = false;
    private Transform assignedResource;
    private void OnEnable()
    {
        name = worker.name;
    }
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
        assignedResource = resource;
        workerAgent.SetDestination(assignedResource.position);
    }

    public void RemovedFromResource()
    {
        workerAgent.SetDestination(RestAreaTransform.position);
    }

    public bool HasReachedResource()
    {
        if (assignedResource)
        {
            var target = Vector3.Distance(transform.position, assignedResource.position);
            hasReachedResource = target <= workerAgent.stoppingDistance;
            if(hasReachedResource) print(worker.name + " has reached resource");
            return hasReachedResource;
        }
        return false;
        //Hide the gameObject and just gather resources
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