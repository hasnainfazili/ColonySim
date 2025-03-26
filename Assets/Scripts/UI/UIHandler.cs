using TMPro;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI oilGathered;
    [SerializeField] private TextMeshProUGUI woodGathered;
    [SerializeField] private TextMeshProUGUI steelGathered;

    public MenuItemPrefab menuItemPrefab;
    public Transform workerListParent;
    private void OnEnable()
    {
        EventManager.GatherableEvents.OnGathered += UpdateGatherableUI;
    }

    private void Awake()
    {
        foreach (var worker in GameManager.workersManager.GetAvailableWorkersList())
        {
            CreateWorkerMenuItem(worker.GetWorker(), menuItemPrefab, workerListParent);
        }
    }


    private void UpdateGatherableUI(Gatherables gatherable)
    {
        // if (gatherable.type == gatherable.GetType()) OilGathered.text = gatherable.name;
    }

    public void CreateWorkerMenuItem<T>(T typeToCreate, MenuItemPrefab menuItemPrefab, Transform parentTransform) where T : Worker
    {
        var createdMenu = Instantiate(menuItemPrefab, parentTransform);
        createdMenu.GetComponent<MenuItemPrefab>().Create(typeToCreate.name, typeToCreate.description, typeToCreate.icon);
    }
    
}