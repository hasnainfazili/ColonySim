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
    private int OilGathered = 0; //Later on use JSON to save
    private int SteelGathered = 0;
    private int WoodGathered = 0;
    
    //Total Resource Storage
    private int TotalOilStorage = 999;
    private int TotalSteelStorage = 999;
    private int TotalWoodStorage = 999;
    
    
   
}
