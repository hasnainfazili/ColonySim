using System;
using UnityEngine;
using UnityEngine.AI;

public class WorkerAI : MonoBehaviour
{
    [SerializeField] protected Worker worker;
    private NavMeshAgent workerAgent;
    //TEMP For testing
    public Transform RestAreaTransform;
    private Transform assignedResource;
    public bool isAssigned;
    private void OnEnable()
    {
        name = worker.name;
    }
    private void Start()
    {
        workerAgent = GetComponent<NavMeshAgent>();
        if(assignedResource == null) isAssigned = false;
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

 
    public Worker GetWorker()
    {
        return worker;
    }

    public WorkerType GetWorkerType()
    {
        return worker.type;
    }
}