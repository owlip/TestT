using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListElement : MonoBehaviour
{
   [Header("Components")]
   [SerializeField] private RectTransform n_transform;
   [Space]
   [SerializeField] private Text n_title;
   [SerializeField] private Text n_description;
   [SerializeField] private Image n_image;


   public void SetTitle(string title){
       n_title.text = title;
   }
   public void SetDescription(string description){
       n_description.text = description;
   }
   
   public void SetImage(Sprite image){
       n_image.sprite = image;
   }



   public float Width(){
       return n_transform.rect.width;
   }
    public float Height(){
       return n_transform.rect.height;
   }
}