using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Seed")]
public class SeedData : ScriptableObject
{
    public string Name;
    public int Price;
    public float Time;
    public Image SeedImage;
}
