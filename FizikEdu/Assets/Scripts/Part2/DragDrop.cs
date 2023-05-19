using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler , IBeginDragHandler , IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public bool movaeable = true;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (movaeable == true)
        {
            Debug.Log("OnBeginDrag");
            canvasGroup.blocksRaycasts = false;

        }
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (movaeable == true)
        {
            Debug.Log("OnDrag");
            canvasGroup.alpha = .6f;

            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
            Debug.Log("OnEndDrag");
            canvasGroup.alpha = 1f;
            canvasGroup.blocksRaycasts = true;
        
            
    }

    public void OnPointerDown(PointerEventData eventData)
    {

        Debug.Log("OnPointerDown");
    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
