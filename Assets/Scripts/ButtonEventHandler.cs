using UnityEngine;

public class ButtonEventHandler : MonoBehaviour
{
    public void WorkerAdded()
    {
        EventManager.Instance.WorkerEvents.WorkerAssigned(GameManager.Instance.AvailableWorkerList[Random.Range(0, GameManager.Instance.AvailableWorkerList.Count)]);  
    }

    public void WorkerRemoved()
    {
        EventManager.Instance.WorkerEvents.WorkerRemoved(GameManager.Instance.AvailableWorkerList[Random.Range(0, GameManager.Instance.AvailableWorkerList.Count)]);
    }
}