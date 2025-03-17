using System;

public class GatherableEvents
{
    public event Action<Gatherables> OnGathered;

    public void Gathered(Gatherables gatherable)
    {
        OnGathered?.Invoke(gatherable);
    }
}