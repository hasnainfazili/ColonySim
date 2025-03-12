using UnityEngine;
using UnityEngine.AI;

public class WorkerAI : MonoBehaviour
{
    private NavMeshAgent workerAgent;
    //TEMP For testing
    public Transform RestAreaTransform;

    public void AssignedToResource(Transform resource)
    {
        workerAgent.SetDestination(resource.position);
        //Once worker reaches destination begin OR add to the production of resource
    }

    public void RemovedFromResource()
    {
        workerAgent.SetDestination(RestAreaTransform.position);
    }
}