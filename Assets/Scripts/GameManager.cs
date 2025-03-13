
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public WorkersManager workersManager;
    //Temp
    private void Awake()
    {
        Instance = this;
        workersManager =  WorkersManager.Instance;
    }
}