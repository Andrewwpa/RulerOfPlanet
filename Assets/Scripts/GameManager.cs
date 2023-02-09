using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject cardGameObject;
    [SerializeField] private CardController cardController;

    public ResourceManager resourceManager;
    public SpriteRenderer cardSpriteRenderer;

    //float
    public float movingSpeed = 1f;

    //UI
    [SerializeField] private TextMeshPro upTextUI;
    [SerializeField] private TextMeshPro downTextUI;
    //cards
    private Card currentCard;
    private string upText;
    private string leftDownText;
    private string rightDownText;
    private CardsCollections cardCollection;

    void Start()
    {
        cardCollection = GetComponent<CardsCollections>();       
        LoadCard(cardCollection.cards[0]);
    }

    // Update is called once per frame
    void Update()
    {       
        if (Input.GetMouseButton(0) && cardController.isMouseOver)
        {
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cardGameObject.transform.position = position;
        }
        else
        {
            cardGameObject.transform.position =
                Vector2.MoveTowards(cardGameObject.transform.position,
                new Vector2(0, 0),
                movingSpeed);
        }
        //Right
        if (cardGameObject.transform.position.x > 1)
        {
            downTextUI.text = rightDownText;

            if (!Input.GetMouseButton(0))
            {
                currentCard.InduceRight();
                NewCard();
            }
        }
        //Left
        else if (cardGameObject.transform.position.x < -1)
        {
            downTextUI.text = leftDownText;
            
            if (!Input.GetMouseButton(0))
            {
                currentCard.InduceLeft();
                NewCard();
            }
        }
        //center point
        else
        {
            downTextUI.text = null;
        }
    }

    public void LoadCard(Card card)
    {
        currentCard = card;
        cardSpriteRenderer.sprite = resourceManager.sprites[(int)card.sprite];
        upText = card.upText;
        upTextUI.text = upText;
        leftDownText = card.leftDownText;
        rightDownText = card.rightDownText;
    }

    public void NewCard()
    {
        int randomNumberCard = Random.Range(1, cardCollection.cards.Length);
        LoadCard(cardCollection.cards[randomNumberCard]);
        
    }

}
