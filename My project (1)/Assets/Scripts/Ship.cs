using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/Ship", fileName = "Ship")]
public class Ship : ObjectData
{
  [SerializeField] private int capacity;
   public int Capacity{
       get{return capacity;}
       protected set{}
   }
   [SerializeField] private int displacement;
   public int Displacement{
       get{return displacement;}
       protected set{}
   }
   [SerializeField] private int lenght;
   public int Lenght{
       get{return lenght;}
       protected set{}
   }
   
}