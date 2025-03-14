using UnityEngine;

public class GatherablesManager : MonoBehaviour
{
    public static GatherablesManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("More than one GatherablesManager in scene.");
        }
        Instance = this;
    }
}