using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> Seed;
    public List<GameObject> Fruit;

    //public GameObject SeedInventory;
   // public GameObject FruitInventory;

    public TextMeshProUGUI NumberSeed;
    public TextMeshProUGUI NumberFruit;


    private int _i;

    void Update()
    {
        /*if (Seed.Count == 10)
        {
            StartCoroutine(EtatSeed());
        }

        if (Fruit.Count == 10)
        {
            StartCoroutine(EtatFruit());
        }*/

        for (int i = 0; i < Seed.Count; i++)
        {
            NumberSeed.text = Seed.Count + " / 10";
        }

        for(int i = 0;i < Fruit.Count; i++)
        {
            NumberFruit.text = Fruit.Count + " / 10";
        }

    }

    /*IEnumerator EtatSeed()
    {
        SeedInventory.SetActive(true);
        yield return new WaitForSeconds(1f);
        SeedInventory.SetActive(false);
    }


    IEnumerator EtatFruit()
    {
        FruitInventory.SetActive(true);
        yield return new WaitForSeconds(1f);
        FruitInventory.SetActive(false);
    }*/
}
