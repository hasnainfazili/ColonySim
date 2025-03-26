using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGatherable
{ 
    public abstract void Gather(GatherableType gatherableType, float gatherAmount, int AssignedWorkers);
}