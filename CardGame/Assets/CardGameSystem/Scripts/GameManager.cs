using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<Card> PlayerDeck;
    public List<Card> EnemyDeck;
    private void Awake()
    {
        if(instance != null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }
    public void PlayCard(Card card)
    {
        if(card.type == "Monster")
        {
            MonsterCard monster = (MonsterCard)card;
            monster.Attack();
        }
        else
        {
            SpellCard spell = (SpellCard)card;
            spell.Heal();
        }
    }
}
