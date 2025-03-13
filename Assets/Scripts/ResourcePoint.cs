using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourcePoint : MonoBehaviour
{
    
    
    private string resourcePointName;
    private string description;
    private bool isGatherableGenerator;
    private Image icon;
    private GatherableType gatherableType;

    public ResourcePointScriptable resourcePointScriptable;
    public float gatherableResourceAmount;
    public List<WorkerAI> WorkersOnResource = new List<WorkerAI>();
    private void OnEnable()
    {
        EventManager.Instance.WorkerEvents.OnWorkerAssigned += WorkerAssigned;
        EventManager.Instance.WorkerEvents.OnWorkerRemoved += WorkerRemoved;

    }
    
    private void OnDisable()
    {
        EventManager.Instance.WorkerEvents.OnWorkerAssigned -= WorkerAssigned;
        EventManager.Instance.WorkerEvents.OnWorkerRemoved -= WorkerRemoved;

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

    private void Update()
    {
       GatherResource();
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
                foreach (WorkerAI worker in WorkersOnResource)
                {
                    worker.transform.SetParent(transform);
                }
            }
    }
    
    private void WorkerAssigned(WorkerAI worker)
    {
        worker.AssignedToResource(transform);
        //Create a UI Element fot the Worker
    }

    private void WorkerRemoved(WorkerAI worker)
    {
        for (var i = 0; i < WorkersOnResource.Count; i++)
        {
            if (WorkersOnResource[i].name != worker.name) continue;
            WorkersOnResource.Remove(WorkersOnResource[i]);
            Destroy(WorkersOnResource[i]);
        }        
    }
    
    private void GatherResource()
    {
        
        if (gatherableResourceAmount > 0)
        {
            if (WorkersOnResource.Count > 0)
            {
                foreach (var t in WorkersOnResource)
                {
                    if(t.HasReachedResource())
                        WorkersOnResource.Add(t);
                }
            }
            gatherableResourceAmount -= (.5f * WorkersOnResource.Count);
            if (!isGatherableGenerator)
            {
                if (gatherableResourceAmount < 0)
                {
                    DestroyResource();
                }
            }
        }
    }

    private void DestroyResource()
    {
        foreach (var w in WorkersOnResource)
        {
            EventManager.Instance.WorkerEvents.WorkerRemoved(w);
        }
    }
}