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
    public void PlayCard(Card card)
    {
        //Llamar al método del GameManager que maneja la lógica de la carta
        GameManager.instance.PlayCard(card);
        //Lógica para ganar experiencia
        XPManager.instance.EarnXP(card.value);
        // Actualizar interfaz de usuario
        DisplayCards();
    }
}
