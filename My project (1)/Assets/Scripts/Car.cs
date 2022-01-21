using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/Car", fileName = "Car")]
public class Car : ObjectData
{
   [SerializeField] private char class_auto;
   public char Class_auto{
       get{return class_auto;}
       protected set{}
   }
   [SerializeField] private string colour;
   public string Colour{
       get{return colour;}
       protected set{}
   }
   [SerializeField] private string driveUnit;
   public string DriveUnit{
       get{return driveUnit;}
       protected set{}
   }
   [SerializeField] private float value;
   public float Value{
       get{return value;}
       protected set{}
   }
    
   
}
