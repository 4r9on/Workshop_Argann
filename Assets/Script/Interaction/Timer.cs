using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Box Box;
    public ListProd ListProd;
    public Harvesting Harvesting;

    public TextMeshProUGUI SeedTimer;
    private float _time;

    private bool _seedIn = false;

    void Update()
    {     
        if (Box.PlantSeed.Count != 0)
        {          
            if (_seedIn == true)
            {
                if(_time > 0)
                {
                    _time -= Time.deltaTime;
                }
                else if (_time < 0 && Box.PlantSeed[0].CompareTag("BLE"))
                {
                    _time = 0;
                    Box.PlantSeed.Add(ListProd.FruitProd[0]);
                    Harvesting.HarvestingOn = true;
                } 

                int minutes = Mathf.FloorToInt(_time / 60);
                int seconds = Mathf.FloorToInt(_time % 60);
                SeedTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
        }
    }



    public void WhatSeed()
    {
        for( int i = 0; i <10; i++ )
        {
            if (Box.PlantSeed[0].CompareTag("BLE") && _time == 0)
            {
                _time += 20;
                _seedIn = true;
            }
        }
    }
}
