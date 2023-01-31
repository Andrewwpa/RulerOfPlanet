using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public Card card;

    SpriteRenderer spriteRenderer;

    public float fMovingSpeed = 1f;

    void Start()
    {
        spriteRenderer = card.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && card.isMouseOver)
        {
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            card.transform.position = position;
        }
        else
        {
            card.transform.position = Vector2.MoveTowards(card.transform.position, new Vector2(0,0), fMovingSpeed);
        }

        if (card.transform.position.x > 2)
        {
            spriteRenderer.color = Color.green;
            if (!Input.GetMouseButton(0))
            {
                card.InduceRight();
            }
        }
        else if (card.transform.position.x < -2)
        {
            spriteRenderer.color = Color.red;
            if (!Input.GetMouseButton(0))
            {
                card.InduceLeft();            
            }
        }
        else
        {
            spriteRenderer.color = Color.white;
        }

    }
}
