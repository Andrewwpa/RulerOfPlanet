using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class Card
{
    [SerializeField] private string cardName;
    [SerializeField] private int cardID;

    public CardSprites sprite;

    [Header("Text")]
    public string upText;
    public string leftDownText;
    public string rightDownText;

    [Header("Indicators")]
    public int technologiesValue;
    public int peoplesValue;
    public int corporationsValue;
    public int economyValue;
    public int healthValue;

    public void InduceRight()
    {
        Debug.Log("Право11");
    }
    public void InduceLeft()
    {
        Debug.Log("Лево11");
    }
}
