﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Realizá un programa que resuelva el siguiente problema: Nos piden desarrollar un
//gresada por el usuario.
//Nosotros sabemos que el estacionamiento se encuentra abierto entre las 10 y las 18hs.
//(Crear constante HORA_APERTURA = 10, y HORA_CIERRE = 18).
//Al iniciar el programa, se tomará como hora actual el valor de una variable expuesta en el
//Inspector, y deberemos setear una variable booleana llamada estaAbierto en true o false,
//según corresponda, e informar por pantalla mediante la misma si el estacionamiento se
//encuentra abierto o no.Obs: En el caso de que el valor de la variable correspona a una hora
//menor a 0 o mayor a 24, mostrar el mensaje: “Ha ingresado una hora incorrecta”

public class Ejercicio10 : MonoBehaviour
{
    public int horario;
    public int Hora_Apertura = 10;
    public int Hora_Cierre = 10;
    bool estaAbierto;
    // Start is called before the first frame update
    void Start()
    {
        if (horario >= Hora_Apertura && Hora_Apertura >= Hora_Cierre)
        {
            estaAbierto = true;
            Debug.Log("El estacionamiento esta abierto");
        }
        else if (horario < Hora_Apertura && horario >= 0)
        {
            estaAbierto = false;
            Debug.Log("El estacionamiento esta cerrado");
        }
        else if (horario > Hora_Apertura && horario <= 24)
        {
            estaAbierto = true;
            Debug.Log("El estacionamiento esta cerrado");
        }
        else if (horario < 0 || horario > 24)
        {
            estaAbierto = false;
            Debug.Log("Ha ingresado una hora incorrecta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
