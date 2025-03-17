using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatherables
{
   public string name;
   public string description;
   public Sprite icon;
   public GatherableType type;

   public Gatherables(string name, string description, Sprite icon, GatherableType type)
   {
      this.name = name;
      this.description = description;
      this.icon = icon;
      this.type = type;
   }
}

public enum GatherableType
{
   Wood,
   Metal,
   Oil
}
