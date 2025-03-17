using System;
using UnityEngine;

public class MenuCardEvents
{
    public event Action<ResourcePointScriptable> OnResourcePointClicked;
    public event Action<ResourcePointScriptable> OnResourcePointHover;

    public void ResourcePointClicked(ResourcePointScriptable resourcePoint)
    {
        OnResourcePointClicked?.Invoke(resourcePoint);
    }

    public void ResourcePointHover(ResourcePointScriptable resourcePoint)
    {
        OnResourcePointHover?.Invoke(resourcePoint);
    }
}