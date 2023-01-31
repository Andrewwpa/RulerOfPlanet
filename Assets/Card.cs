using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public bool isMouseOver = false;
    private void OnMouseOver()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }

    public void InduceRight()
    {
        Debug.Log("Право");
    }

    public void InduceLeft()
    {
        Debug.Log("Лево");
    }
}
