using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Realizá un programa que resuelva el siguiente problema:  
////Se desea saber qué porcentaje del total aportó cada una (indicando nombre y porcentaje) 
//y cuál es el monto del total aportado por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas
//y luego  mostrar lo pedido en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 
public class Ejercicio9 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;

    public int cap1;
    public int cap2;
    public int cap3;
    // Start is called before the first frame update
    void Start()
    {
        int captotal = cap1 + cap2 + cap3;
        int porcentaje1 = cap1 * 100 / captotal;
        int porcentaje2 = cap2 * 100 / captotal;
        int porcentaje3 = cap3 * 100 / captotal;
        Debug.Log("Se aportaron " + captotal + " pesos en total");
        Debug.Log("La persona 1 aporto el capital " + cap1 + " pesos. Aporto un " + porcentaje1 + "% del capital");
        Debug.Log("La persona 2 aporto el capital " + cap2 + " pesos. Aporto un " + porcentaje2 + "% del capital");
        Debug.Log("La persona 3 aporto el capital " + cap3 + " pesos. Aporto un " + porcentaje3 + "% del capital");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
