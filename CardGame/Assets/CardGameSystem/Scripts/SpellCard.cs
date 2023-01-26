using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Crear una clase derivada para cada tipo de carta distinto
    Carta Sanadora
    HEALING
*/
public class SpellCard : Card
{
    public int healing;

    public void Heal()
    {
        Debug.Log(nameCard + " heals for " + healing + " points.");
    }
}
