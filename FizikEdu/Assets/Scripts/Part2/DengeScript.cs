using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DengeScript : MonoBehaviour
{
    public static DengeScript Instance;
    [SerializeField] Text dengeTxt;
    string dengede = "Dengede";
    string dengesiz = "Dengesiz";
    public int platform1Skor;
    public int platform2Skor;
    public GameObject Platform1;
    public GameObject Platform2;

    private void Awake()
    {
        Instance = this;
    }

    public void DengeDurumu()
    {
        platform1Skor= Platform1.GetComponent<ItemSlot>().skor;
        platform2Skor = Platform2.GetComponent<ItemSlot>().skor;
        if (platform1Skor == platform2Skor)
        {
            dengeTxt.text = dengede.ToString();
        }
        else
            dengeTxt.text = dengesiz.ToString();
    }
}
