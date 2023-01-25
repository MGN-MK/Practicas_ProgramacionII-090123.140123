using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Crear una clase derivada para cada tipo de carta distinto
    Carta de Ataque
    ATTACK, DEFENSE
*/
public class MonsterCard : Card
{
    public int attack;
    public int defense;

    public void Attack()
    {
        Debug.Log(nameCard + " attacks with " + attack + " points of demage.");
    }
    public void Defense()
    {
        Debug.Log(nameCard + " defense with " + defense + " points of shield.");
    }
}
