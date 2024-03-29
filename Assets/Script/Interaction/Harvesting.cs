using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvesting : MonoBehaviour
{
    public Box Box;
    public Inventory Inventory;
    
    [SerializeField]
    public bool HarvestingOn = false;

    public GameObject HarvestingUI;


    private void OnTriggerEnter(Collider other)
    {
        if (HarvestingOn == true)
        {
            HarvestingUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        HarvestingUI.SetActive(false);
    }

    public void Harvest()
    {
        Inventory.Fruit.Add(Box.PlantSeed[0]);
        Box.PlantSeed.Clear();
        HarvestingUI.SetActive(false);
    }


}
