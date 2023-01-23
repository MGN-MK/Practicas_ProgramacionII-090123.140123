using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardUIManager : MonoBehaviour
{
    public List<Card> deck;
    public GameObject cardPrefab;
    public Transform cardParent;

    void DisplayCards()
    {
        foreach(Card card in deck)
        {
            GameObject newCard = Instantiate(cardPrefab, cardParent);
        }
    }
}
