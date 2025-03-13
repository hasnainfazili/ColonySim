using UnityEngine;

public class ButtonEventHandler : MonoBehaviour
{
    public void WorkerAdded()
    {
        EventManager.Instance.WorkerEvents.WorkerAssigned(
            GameManager.Instance.workersManager.GetAvailableWorkersList()[Random.Range(0, 2)]);
    }

    public void WorkerRemoved()
    {
        EventManager.Instance.WorkerEvents.WorkerRemoved(
            GameManager.Instance.workersManager.GetAvailableWorkersList()[Random.Range(0, 2)]);;
    }
}