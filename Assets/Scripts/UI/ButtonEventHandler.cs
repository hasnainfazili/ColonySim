using UnityEngine;

public class ButtonEventHandler : MonoBehaviour
{
    
    //This could be an interface?
    public void WorkerAdded()
    {
        EventManager.Instance.WorkerEvents.WorkerAssigned(
            GameManager.workersManager.GetAvailableWorkersList()[Random.Range(0, GameManager.workersManager.GetAvailableWorkersList().Count)]);
    }

    public void WorkerRemoved()
    {
        EventManager.Instance.WorkerEvents.WorkerRemoved(
            GameManager.workersManager.GetAvailableWorkersList()[Random.Range(0, GameManager.workersManager.GetAvailableWorkersList().Count)]);;
    }
}/**/