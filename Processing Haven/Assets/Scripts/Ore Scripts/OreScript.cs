using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Ore,
    Bar
}

public enum Material
{
    Copper,
    Iron,
    Gold
}

public class OreScript : MonoBehaviour
{
    public float value;
    public ItemType type;
    public Material material;
}