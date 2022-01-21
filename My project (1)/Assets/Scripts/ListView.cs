using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListView : MonoBehaviour
{
   [Header("Component")]
   [SerializeField] private Transform n_ContentTransform;
   [SerializeField] private RectTransform n_ContentRectTransform;

   [Header("Settings")]
   [SerializeField] private List<GameObject> n_elements;
   [SerializeField] private float n_offset;

   
   public GameObject Add(GameObject element){
       
       GameObject createdElement = Instantiate(element, this.n_ContentTransform);
   
        if(this.n_elements.Count == 0){
            this.n_elements.Add(createdElement);
            return createdElement;
        }
   

        ListElement elementMeta = createdElement.GetComponent<ListElement>();
        GameObject LastElement = this.n_elements[n_elements.Count-1];

        Vector3 lastElementPosition = LastElement.transform.localPosition;

        Vector3 newElementPosition = new Vector3{
            x = lastElementPosition.x,
            y = lastElementPosition.y - elementMeta.Height() - this.n_offset,
            z = lastElementPosition.z
        };

        createdElement.transform.localPosition = newElementPosition;

        this.n_elements.Add(createdElement);

        float contentHeight = this.n_ContentRectTransform.rect.height;

        contentHeight += this.n_offset + elementMeta.Height();

        this.n_ContentRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, contentHeight);

        
        return createdElement;
    }
}
