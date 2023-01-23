using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : EnemyBase
{
    public override void Init()
    {
        base.Init();
    }
    public override int GetHealth()
    {
        return base.GetHealth();
    }
    public override List<string> GetLoot()
    {
        return base.GetLoot();
    }
    public override void AddLoot(string Item)
    {
        base.AddLoot(Item);
    }
    private void Start()
    {
        Init();
        AddLoot("Sword");
        AddLoot("Shield");
        AddLoot("Gold");

        //Imprimir el Loot
        for(int i = 0; i < GetLoot().Count; i++)
        {
            Debug.Log(GetLoot()[i]);
        }
    }
}
