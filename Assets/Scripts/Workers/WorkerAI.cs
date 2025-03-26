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
    private void OnEnable()
    {
        name = worker.name;
    }
    private void Start()
    {
        workerAgent = GetComponent<NavMeshAgent>();
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