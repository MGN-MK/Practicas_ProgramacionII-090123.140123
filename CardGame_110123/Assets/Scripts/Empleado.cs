using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empleado : Persona
{
    public int MontoDeTransferencia = 500;
    public int Dias;

    public override void GetInfo()
    {
        Nombre = "Roberto";
        ID = 1234;
        base.GetInfo();
        Debug.Log("El empleado tiene un monto propuesto de transferencia: " + MontoDeTransferencia);
    }

    public override void Asistencia()
    {
        Asisti = Dias;
        base.Asistencia();
    }

    private void Start()
    {
        GetInfo();
        Asistencia();
    }
}
