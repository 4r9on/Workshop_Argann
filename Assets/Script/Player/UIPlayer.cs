using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPlayer : MonoBehaviour
{
    public TextMeshProUGUI Money;
    public Money money;

    void Update()
    {
        Money.text = "" + money.PlayerMoney;
    }
}
