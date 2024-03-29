using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Fruit")]
public class FruitData : ScriptableObject
{
    public string Name;
    public int Price;
    public Image SeedImage;
}
