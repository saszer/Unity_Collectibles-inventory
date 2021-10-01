using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class EventOnHover : MonoBehaviour, IPointerEnterHandler
{

    [SerializeField] private UnityEvent doOnhover;

    public void OnPointerEnter(PointerEventData eventData)
    {
        doOnhover.Invoke();
    }
}
