using UnityEngine;
using System.Collections;

public class CardController : MonoBehaviour 
{
    public GameObject CardPrefab;

    public int CardCount = 10;
    public float CardSpacing = 24f;

    private void Start()
    {
        RectTransform tempRef = null;

        RectTransform panelRectTransform = gameObject.GetComponent<RectTransform>();
        float cardWidth = CardPrefab.GetComponent<RectTransform>().rect.width;
        float cardsTotalWidth = CardCount * cardWidth;
        cardsTotalWidth += (CardCount - 1) * CardSpacing;
        Vector3 startPos = panelRectTransform.position;
        startPos.x += cardWidth * 0.5f;
            
        startPos.x -= (cardsTotalWidth * 0.5f);

        for (int i = 0; i < CardCount; i++)
        {
            tempRef = GameObject.Instantiate(CardPrefab).GetComponent<RectTransform>();
            tempRef.SetParent(transform, true);
            tempRef.position = startPos;
            startPos.x += CardSpacing + cardWidth;
        }
    }
}
