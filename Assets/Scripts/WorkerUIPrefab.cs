using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WorkerUIPrefab
{
    public TextMeshProUGUI WorkerName;
    public TextMeshProUGUI WorkerType;
    public Image WorkerIcon;

    public WorkerUIPrefab(Worker worker)
    {
        this.WorkerName.text = worker.name;
        this.WorkerType.text = worker.type.ToString();
        this.WorkerIcon.sprite = worker.icon;
    }
}

