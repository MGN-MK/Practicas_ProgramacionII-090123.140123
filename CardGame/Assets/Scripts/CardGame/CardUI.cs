using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardUI : MonoBehaviour
{
    public TMP_Text Name;
    public TMP_Text value;
    public TMP_Text type; //Puede ser un ENUM
    public Sprite image;

    private Card card;

    public void SetUp(Card newCard)
    {
        card = newCard;
        Name.text = card.nameCard;
        value.text = "Value: " + card.value.ToString();
        type.text = "Type: " + card.type;
        image = card.image;
    }
}
