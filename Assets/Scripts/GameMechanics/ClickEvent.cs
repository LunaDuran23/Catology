using UnityEngine.EventSystems;
using UnityEngine;

public class ClickEvent : MonoBehaviour, IPointerDownHandler
{


    public void OnPointerDown(PointerEventData eventData)
    {
        GetComponent<Card>().ShowCard();
    }
}
