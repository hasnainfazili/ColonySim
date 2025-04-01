using System.Collections.Generic;
using UnityEngine;

public class WorkersManager : MonoBehaviour
{
    public static WorkersManager Instance { get; private set; }

    private int _totalNumberOfWorkers;
    private int _availableWorkers;

    private int _handymanWorkers;
    private int _smartypantWorkers;

    [SerializeField] private List<WorkerAI> AllWorkers = new List<WorkerAI>();
    [SerializeField] private List<WorkerAI> AvailableWorkers = new List<WorkerAI>();
    [SerializeField] private List<WorkerAI> AssignedWorkers = new List<WorkerAI>();
    public void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("More than one instance of Workers Manager");
        }
        Instance = this;

        if (AllWorkers.Count != 0)
        {
            foreach (var worker in AllWorkers)
            {
                if (!worker.isAssigned)
                {
                    AvailableWorkers.Add(worker);
                }
            
            }
        }
    }

    public void Start()
    {
        
    }
    public void AddWorkerToList(WorkerAI worker, List<WorkerAI> addToList)
    {
    
    }

    #region Get for All Workers

    public int GetTotalWorkers()
    {
        return _totalNumberOfWorkers;
    }

    public int GetHandymanWorkers()
    {
        foreach (var w in AllWorkers)
        {
            if(w.GetWorkerType() == WorkerType.Handyman)
                _handymanWorkers ++;
        }
        return _handymanWorkers;
    }

    public int GetSmartypantWorkers()
    {
        foreach (var w in AllWorkers)
        {
            if(w.GetWorkerType() == WorkerType.Smartypants)
                _smartypantWorkers ++;
        }
        return _smartypantWorkers;
    }

    public List<WorkerAI> GetAssignedWorkersList()
    {
        return AssignedWorkers;
    }
    public List<WorkerAI> GetAvailableWorkersList()
    {
        return AvailableWorkers;
    }

    #endregion
   
}