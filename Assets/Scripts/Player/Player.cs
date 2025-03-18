using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Workers under the player
    public int TotalWorkers;
    public int Handymans;
    public int SmartyPants;
    
    //Current Resources
    private int OilGathered;
    private int SteelGathered;
    private int WoodGathered;
    
    //Total Resource Storage
    private int TotalOilStorage;
    private int TotalSteelStorage;
    private int TotalWoodStorage;

    private WorkersManager _workersManager;
    private GatherablesManager _gatherablesManager;
    void Awake()
    {
        _workersManager = GameManager.workersManager;
        _gatherablesManager = GameManager.gatherablesManager;
    }

    void Start()
    {
        TotalWorkers = _workersManager.GetTotalWorkers();
        Handymans = _workersManager.GetHandymanWorkers();
        SmartyPants = _workersManager.GetSmartypantWorkers();
        
        OilGathered = _gatherablesManager.GetOilGathered();
        SteelGathered = _gatherablesManager.GetSteelGathered();
        WoodGathered = _gatherablesManager.GetWoodGathered();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

   
}
