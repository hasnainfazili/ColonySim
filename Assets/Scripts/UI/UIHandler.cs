using UnityEngine;

public class UIHandler : MonoBehaviour
{
    private int OilGathered;
    private int WoodGathered;
    private int SteelGathered;

    private void OnEnable()
    {
        EventManager.GatherableEvents.OnGathered += UpdateResource;
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
}