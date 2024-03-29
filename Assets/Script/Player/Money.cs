using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    public int PlayerMoney;
    public TextMeshProUGUI MoneyText;

    void Update()
    {
        MoneyText.text = "" + PlayerMoney;
        if(PlayerMoney == 0)
        {
            PlayerMoney = 0;
        }
    }

}
