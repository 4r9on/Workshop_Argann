using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public Inventory Inventory;
    public Box Box;

    public void PlantIn()
    {
        if (Inventory.Seed.Count > 0 && Box.PlantSeed.Count == 0)
        {            
            for (int i = 0; i < Inventory.Seed.Count; i--)
            {
                Box.PlantSeed.Add(Inventory.Seed[i]);
                Inventory.Seed.RemoveAt(i);
                Box.In = true;
            }
        }
        else
        {
            Debug.Log("Plein");
        }
    }
}
