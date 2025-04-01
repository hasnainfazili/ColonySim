using UnityEngine;

public class ButtonEventHandler : MonoBehaviour
{
    
    //This could be an interface?
    public void WorkerAdded()
    {
        EventManager.Instance.WorkerEvents.WorkerAssigned(
            WorkersManager.Instance.GetAvailableWorkersList()[Random.Range(0, WorkersManager.Instance.GetAvailableWorkersList().Count)]);
    }

    public void WorkerRemoved()
    {
        EventManager.Instance.WorkerEvents.WorkerRemoved(
           WorkersManager.Instance.GetAvailableWorkersList()[Random.Range(0, WorkersManager.Instance.GetAvailableWorkersList().Count)]);;
    }
}/**/