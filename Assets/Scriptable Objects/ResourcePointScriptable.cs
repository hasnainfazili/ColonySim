using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(menuName = "Colony Sim/Resource Point")]
public class ResourcePointScriptable : ScriptableObject
{
    public string pointName;
    public string pointDescription;
    public bool isGatherableGenerator;
    public Sprite pointSprite;
    public GatherableType pointGatherableType;
}