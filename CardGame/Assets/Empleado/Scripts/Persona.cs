using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
    protected string Nombre;
    protected int Edad;
    protected int ID;
    protected int DiasTotal = 3654;
    protected int EmpTotal = 50;
    protected int Asisti;

    // Constructor vacio
    public Persona()
    {
        Nombre = "Montserrat";
        Edad = 24;
    }

    // Constructor por parametros
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void SetName(string _name)
    {
        Nombre = _name;
    }

    public string GetName()
    {
        return Nombre;
    }

    public virtual void GetInfo()
    {
        Debug.Log("Nombre: " + Nombre);
        Debug.Log("ID: " + ID);
    }

    public virtual void Asistencia()
    {
        Debug.Log("Dias laborales: " + DiasTotal);
        Debug.Log("Faltas: " + (DiasTotal - Asisti));
    }
}
