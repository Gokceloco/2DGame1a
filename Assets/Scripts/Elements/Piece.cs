using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Piece : MonoBehaviour
{
    public TextMeshPro healthTMP;
    public Vector2 startHealthRange;

    public int startHealth;

    public void Init()
    {
        startHealth = Mathf.RoundToInt(UnityEngine.Random.Range(startHealthRange.x, startHealthRange.y));
        healthTMP.text = startHealth.ToString();
    }
}
