using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovingHand : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public void Aaa()
    {
        Debug.Log("111");
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
    }

    public void OnEndDrag(PointerEventData eventData)
    {
    }
}
