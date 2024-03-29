using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public List<GameObject> PlantSeed;

    public GameObject UiInv;
    //public GameObject Time;

    public bool In = false;

    private void OnTriggerEnter(Collider other)
    {
        if (In == false)
        {
            Debug.Log("mmm");
            if (other.gameObject.CompareTag("Player"))
            {
                UiInv.SetActive(true);
            }
        }
        /*else
        {
            Time.SetActive(true);

        }*/
    }

    private void OnTriggerExit(Collider other)
    {
        if (In == true)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                UiInv.SetActive(false);
            }
        }
        else
        {
            UiInv.SetActive(false);
       
        }
    }
}
