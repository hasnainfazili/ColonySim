using UnityEngine;

public class WorkerUIHandler : MonoBehaviour
{
    //This is the base which will spawn for each Worker 
    [SerializeField] private WorkerUIPrefab workerUIPrefab;
    //WorkerName, Worker Type, Resource on which is working
    
    private void CreateWorkerUI(WorkerAI workerAI)
    {
            
    }
    
    
    //Handle the addition and removal of the item from each resource points list
    //a general population or worker list is being kept inside the workermanager
    //so get the list and select a random worker. 
    //Later on change it to type T as in players can choose whether it's a handy man or smartypants
}