using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/Plane", fileName = "Plane")]
public class Plane : ObjectData
{
   [SerializeField] private string type_plane;
   public string Type_plane{
       get{return type_plane;}
       protected set{}
   }
   [SerializeField] private int loadCapacity;
   public int LoadCapacity{
       get{return loadCapacity;}
       protected set{}
   }
   [SerializeField] private int capacity;
   public int Capacity{
       get{return capacity;}
       protected set{}
   }
   [SerializeField] private int maxDistance;
   public int MaxDistance{
       get{return maxDistance;}
       protected set{}
   }
}