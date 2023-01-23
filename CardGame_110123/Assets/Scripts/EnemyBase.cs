using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    protected string Name = "Enemy";
    protected int Health = 100;
    protected List<string> Loot;

    public virtual void Init()
    {
        Loot = new List<string>();
    }

    public virtual void AddLoot(string Item)
    {
        Loot.Add(Item);
    }

    public virtual List<string> GetLoot()
    {
        return Loot;
    }

    public virtual int GetHealth()
    {
        return Health;
    }
}
