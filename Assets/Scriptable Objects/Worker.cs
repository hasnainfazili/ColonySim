using UnityEngine;

[CreateAssetMenu(fileName = "John Doe", menuName = "Colony Sim/Workers")]
public class Worker : ScriptableObject
{
    public int id;
    public new string name;
    public  string description;
    public  Sprite icon;
    public WorkerType type;
}