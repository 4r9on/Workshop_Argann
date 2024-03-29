using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    public SeedData seedData;

    float _time;
    public int Price;

    private void Start()
    {
        _time = seedData.Time;
        Price = seedData.Price;
    }
}
