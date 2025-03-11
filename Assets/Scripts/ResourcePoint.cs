using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourcePoint : MonoBehaviour
{
    [SerializeField] private GameObject WorkerNamePrefab;
    [SerializeField] private Transform ListParent;
    
    
    private string resourcePointName;
    private string description;
    private bool isGatherableGenerator;
    private Image icon;
    private GatherableType gatherableType;

    public ResourcePointScriptable resourcePointScriptable;
    // public float gatherableResourceAmount;
    public List<GameObject> WorkersOnResource = new List<GameObject>();
    private void OnEnable()
    {
        EventManager.Instance.WorkerEvents.OnWorkerAssigned += WorkerAssigned;
        EventManager.Instance.WorkerEvents.OnWorkerRemoved += WorkerRemoved;

    }
    

    private void OnMouseDown()
    {
        
        EventManager.Instance.MenuCardEvents.ResourcePointClicked(resourcePointScriptable);
        InitializeResourcePoint();
        
    }

    private void OnMouseOver()
    {
        EventManager.Instance.MenuCardEvents.ResourcePointHover(resourcePointScriptable);
    }

    private void InitializeResourcePoint()
    {
            resourcePointName = resourcePointScriptable.pointName;
            description = resourcePointScriptable.pointDescription;
            isGatherableGenerator = resourcePointScriptable.isGatherableGenerator;
            gatherableType = resourcePointScriptable.pointGatherableType;
            
            name = resourcePointName;

            if (WorkersOnResource.Count != 0)
            {
                foreach (GameObject worker in WorkersOnResource)
                {
                    var workerName = Instantiate(WorkerNamePrefab, ListParent, false);
                    workerName.GetComponent<TextMeshProUGUI>().text = worker.name;
                    workerName.name = worker.name;
                }
            }
    }

    private void WorkerAssigned(Worker worker)
    {
        var workerName = Instantiate(WorkerNamePrefab, ListParent, false);
        workerName.GetComponent<TextMeshProUGUI>() .text= worker.name;
        WorkersOnResource.Add(workerName);                
        workerName.name = worker.name;

        //WorkerAssigned Also Sets NavMeshAgent to ResourcePoint
        //Gathering Resources will start once the worker reaches the resource
    }

    private void WorkerRemoved(Worker worker)
    {
        for (var i = 0; i < WorkersOnResource.Count; i++)
        {
            if (WorkersOnResource[i].name != worker.name) continue;
            WorkersOnResource.Remove(WorkersOnResource[i]);
            Destroy(WorkersOnResource[i]);
        }        
        //Destroy When Worker Remove Called
    }
    
    public void GatherResource()
    {
        //Also Calculated by which worker is assigned 
        // if (gatherableResourceAmount > 0)
        // {
        //     //Check if workers are assigned
        //     //Depending on the amount of workers speed of resource gathered
        //     //if resourceAmount reaches zero deassign workers and remove gameObject CLEANUP
        // }
    }
}