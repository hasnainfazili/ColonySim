using UnityEngine;

public class Workers
{
    public Worker Worker;

    public int Id;
    public string Name;
    public string Description;
    public Sprite Icon;
    public WorkerType Type;
    public Workers(Worker worker)
    {
        Id = worker.id;
        this.Name = worker.name;
        this.Description = worker.description;
        this.Icon = worker.icon;
        this.Type = worker.type;
      
    }
   
}

public enum WorkerType
{
    Handyman,
    Smartypants
}