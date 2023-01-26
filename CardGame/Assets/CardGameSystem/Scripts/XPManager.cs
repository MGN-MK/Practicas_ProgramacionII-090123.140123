using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPManager : MonoBehaviour
{
    public static XPManager instance;
    public int playerXP;
    public int lv;
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
    void CheckLevelUp()
    {
        if (playerXP >= 100)
        {
            lv++;
            Debug.Log("Player level up " + lv);
            //Agregar lógica para desbloquear nuevas cartas o mejorar las existentes
        }
    }
    public void EarnXP(int amaount)
    {
        playerXP += amaount;
        CheckLevelUp();
    }
}
