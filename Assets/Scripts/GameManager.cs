
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public static WorkersManager workersManager;
    public static GatherablesManager gatherablesManager;
    //Temp
    private void Awake()
    {
        Instance = this;
        workersManager =  WorkersManager.Instance;
        gatherablesManager =  GatherablesManager.Instance;
    }
}