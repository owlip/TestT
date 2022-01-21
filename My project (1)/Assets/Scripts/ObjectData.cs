using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/Base Object", fileName = "NewObject")]
public class ObjectData : ScriptableObject {

   [Tooltip("Масса")]
   [SerializeField] private int mass;
   public int Mass{
       get{return mass;}
       protected set{}
   }

   

   [Tooltip("Максимальная скорость")]
   [SerializeField] private int maxSpeed;
   public int MaxSpeed{
       get{return maxSpeed;}
       protected set{}
   }

   [Tooltip("Тип транспорта")]
   [SerializeField] private string type;
   public string Type{
       get{return type;}
       protected set{}
   }

   [Tooltip("Марка")]
   [SerializeField] private string brand;
   public string Brand{
       get{return brand;}
       protected set{}
   }

   [Tooltip("Страна")]
   [SerializeField] private string country;
   public string Country{
       get{return country;}
       protected set{}
   }

   
}