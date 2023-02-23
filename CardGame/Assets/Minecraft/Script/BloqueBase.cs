using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueBase : MonoBehaviour
{
    public string blockName;
    public bool gravity;
    public bool breakable;
    public Sprite texture;

    public virtual void DestroyBlock()
    {

    }
}
