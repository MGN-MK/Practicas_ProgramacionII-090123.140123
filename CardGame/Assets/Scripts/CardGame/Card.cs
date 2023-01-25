using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Crear una clase base "Card" que contenga las propiedades básicas de todas las cartas
    NOMBRE, VALOR, TIPO, IMAGE
*/
public class Card
{
    public string nameCard;
    public int value;
    public string type; //Puede ser un ENUM
    public Sprite image;

    public void DisplayCard()
    {
        Debug.Log("Name: " + nameCard + "Value: " + value + "Type: " + type);
    }
}