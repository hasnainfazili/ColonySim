using UnityEngine;

public class GatherablesManager : MonoBehaviour
{
    public static GatherablesManager Instance { get; private set; }
    private int OilGathered;
    private int WoodGathered;
    private int SteelGathered;

    private void OnEnable()
    {
        EventManager.GatherableEvents.OnGathered += UpdateResource;
    }
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("More than one GatherablesManager in scene.");
        }

        Instance = this;
    }
    private void UpdateResource(Gatherables gatherables)
    {
        if (gatherables.type == GatherableType.Oil)
        {
            OilGathered++;
        }

        if (gatherables.type == GatherableType.Wood)
        {
            WoodGathered++;
        }

        if (gatherables.type == GatherableType.Metal)
        {
            SteelGathered++;
        }
    }

    public int GetOilGathered()
    {
        return OilGathered;
    }

    public int GetWoodGathered()
    {
        return WoodGathered;
    }

    public int GetSteelGathered()
    {
        return SteelGathered;
    }

}