using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public int skor;
    [SerializeField] Text skortxt;
    public Vector2 konum;
    [SerializeField] float xNum;
    private void Awake()
    {
        xNum = -140f;
        konum = new Vector2(xNum, 70f);
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
            if(eventData.pointerDrag.GetComponent<DragDrop>().movaeable == true)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition + konum;
                eventData.pointerDrag.GetComponent<DragDrop>().movaeable = false;
                SkorEkle();
                DengeScript.Instance.DengeDurumu();
                xNum += 70;
                if (xNum >= 250)
                {
                    xNum = -140f;
                }
                konum = new Vector2(xNum, 70f);
                Debug.Log(xNum);
            }
            
        }
        
    }

    public void SkorEkle()
    {
        skor += 10;
        skortxt.text = skor.ToString();
    }
}
