using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : BloqueBase
{
    private void Start()
    {
        blockName = "Diamante";
        gravity = false;
        breakable = false;
        GetComponent<SpriteRenderer>().sprite = texture;
    }

    public override void DestroyBlock()
    {
        DropItem();
        DropXP();
        BreakSound();
    }

    public void DropItem()
    {

    }

    public void DropXP()
    {

    }

    public void BreakSound()
    {

    }
}
