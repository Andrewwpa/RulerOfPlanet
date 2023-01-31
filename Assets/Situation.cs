using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Situation : MonoBehaviour
{
    public Card currentCard;

    public TextMeshPro currentDialoge;
    public TextMeshPro leftAnswer;
    public TextMeshPro rightAnswer;

    public Indicators indicators;

    public float humorRight;
    public float humorLeft;
    public float reputationRight;
    public float reputationLeft;
    public float originalityRight;
    public float originalityLeft;

    public void ÑhoiceRight()
    {
        indicators.humor += humorRight;
        indicators.reputation += reputationRight;
        indicators.originality += originalityRight;
        
    }
    public void ÑhoiceLeft()
    {
        indicators.humor += humorLeft;
        indicators.reputation += reputationLeft;
        indicators.originality += originalityLeft;
    }
}
