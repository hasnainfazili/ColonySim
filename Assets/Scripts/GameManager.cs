
using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    //Temp
    public List<Worker> AvailableWorkerList = new List<Worker>();
    private void Awake()
    {
        Instance = this;
    }
}