using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleComponent : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private ListView n_listView;
    [SerializeField] private GameObject n_Prefab;
    [SerializeField] private List<Sprite> n_Image;
    [SerializeField] private DataBase _DataBase;
    

    private void Awake() {
       
       for(int i= 0; i<_DataBase._Car.Count;i++){
           
            GameObject element = this.n_listView.Add(this.n_Prefab);

            ListElement elementMeta = element.GetComponent<ListElement>();
    
            elementMeta.SetTitle(_DataBase._Car[i].name);
            elementMeta.SetImage(this.n_Image[0]);
            elementMeta.SetDescription(_DataBase.PrintCar(i));
           
       }

       for(int i= 0; i<_DataBase._Ship.Count;i++){
           
            GameObject element = this.n_listView.Add(this.n_Prefab);

            ListElement elementMeta = element.GetComponent<ListElement>();
    
            elementMeta.SetTitle(_DataBase._Ship[i].name);
            elementMeta.SetImage(this.n_Image[2]);
            elementMeta.SetDescription(_DataBase.PrintShip(i));
            
       }

       for(int i= 0; i<_DataBase._Plane.Count;i++){
           
            GameObject element = this.n_listView.Add(this.n_Prefab);

            ListElement elementMeta = element.GetComponent<ListElement>();
    
            elementMeta.SetTitle(_DataBase._Plane[i].name);
            elementMeta.SetImage(this.n_Image[1]);
            elementMeta.SetDescription(_DataBase.PrintPlane(i));
            
       }
       
       
    }

}
