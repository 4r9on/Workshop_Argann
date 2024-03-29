using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public FruitData fruitData;

    public int Price;

    void Update()
    {
        Price = fruitData.Price;
    }
}
