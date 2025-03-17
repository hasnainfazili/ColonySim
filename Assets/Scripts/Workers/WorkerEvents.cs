using System;
using UnityEngine;

public class WorkerEvents
{
    public event Action<WorkerAI> OnWorkerAssigned;
    public event Action<WorkerAI> OnWorkerRemoved;


    public void WorkerAssigned(WorkerAI worker)
    {
        OnWorkerAssigned?.Invoke(worker);
    }
    
    
    public void WorkerRemoved(WorkerAI worker)
    {
        OnWorkerRemoved?.Invoke(worker);
    }
}