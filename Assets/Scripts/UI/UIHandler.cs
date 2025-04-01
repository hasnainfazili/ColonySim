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

    private void Start()
    {
            foreach (var w in WorkersManager.Instance.GetAvailableWorkersList())
            {
                CreateWorkerMenuItem(w.GetWorker(), menuItemPrefab, workerListParent);
            }
    }


    private void UpdateGatherableUI(Gatherables gatherable)
    {
        // if (gatherable.type == gatherable.GetType()) OilGathered.text = gatherable.name;
    }

    private static void CreateWorkerMenuItem<T>(T typeToCreate, MenuItemPrefab itemPrefab, Transform parentTransform) where T : Worker
    {
        var createdMenu = Instantiate(itemPrefab, parentTransform);
        createdMenu.GetComponent<MenuItemPrefab>().Create(typeToCreate.name, typeToCreate.type.ToString(), typeToCreate.icon);
    }
    
}