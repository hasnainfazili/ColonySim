using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance {get; private set;}

    public MenuCardEvents MenuCardEvents;
    public WorkerEvents WorkerEvents;
    public static GatherableEvents GatherableEvents;
    public void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("More than one instance of MenuCardManager");
        }
        Instance = this;
        MenuCardEvents = new MenuCardEvents();
        WorkerEvents = new WorkerEvents();
        GatherableEvents = new GatherableEvents();
    }

}