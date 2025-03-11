using System;
using UnityEngine;

public class WorkerEvents
{
    public event Action<Worker> OnWorkerAssigned;
    public event Action<Worker> OnWorkerRemoved;


    public void WorkerAssigned(Worker worker)
    {
        OnWorkerAssigned?.Invoke(worker);
    }
    
    
    public void WorkerRemoved(Worker worker)
    {
        OnWorkerRemoved?.Invoke(worker);
    }
}