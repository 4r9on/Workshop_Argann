using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : MonoBehaviour
{
    public Seed Seed;
    public Fruit Fruit;
    public Money Money;
    public Inventory Inventory;

    public GameObject PrefabSeed;

    public GameObject UIMerche;


    public void LessMoney()
    {
        if(Money.PlayerMoney >= Seed.Price)
        {
            Money.PlayerMoney -= Seed.Price;
            Inventory.Seed.Add(PrefabSeed);
        }
    }

    public void WinMoney()
    {
        Money.PlayerMoney += Fruit.Price;
        Inventory.Fruit.Remove(PrefabSeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        UIMerche.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            UIMerche.SetActive(false);
    }
}
