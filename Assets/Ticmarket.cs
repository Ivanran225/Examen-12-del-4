using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticmarket : MonoBehaviour
{
    public string Prdoucto1;
    public int Precio1;
    public int Cant1;

    public string Prdoucto2;
    public int Precio2;
    public int Cant2;

    public string Prdoucto3;
    public int Precio3;
    public int Cant3;

    double Total1;
    double Total2;
    double Total3;

    double porciento1;
    double porciento2;
    double porciento3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Cant1 > 3)
        {
            Total1 = Cant1 * Precio1;
            porciento1 = Total1 * 0.2;
            Total1 = Total1 - porciento1;
            Debug.Log("Valor final prodcuto1: " + Total1);
        }
        else{
            Total1 = Precio1 * Cant1;
            Debug.Log("Valor final prodcuto1: " + Total1);
        }
        if (Cant2 > 3)
        {
            Total2 = Cant2 * Precio2;
            porciento2 = Total2 * 0.2;
            Total2 = Total2 - porciento2;
            Debug.Log("Valor final prodcuto2: " + Total2);
        }
        else
        {
            Total2 = Precio2 * Cant2;
            Debug.Log("Valor final prodcuto2: " + Total2);
        }
        if (Cant3 > 3)
        {
            Total3 = Cant3 * Precio3;
            porciento3 = Total3 * 0.2;
            Total3 = Total3 - porciento3;
            Debug.Log("Valor final prodcuto3: " + Total3);
        }
        else
        {
            Total3 = Precio3 * Cant3;
            Debug.Log("Valor final prodcuto3: " + Total3);
        }
        if (Cant1 < 1 && Precio1 < 1 && Cant2 < 1 && Precio2 < 1 && Cant3 < 1 && Precio3 < 1)
        {
            Debug.Log("Alguno de los precios y/o las cantidades de los productos es menos que 1");
        }
        double Total123;
        Total123 = Total1 + Total2 + Total3;
        Debug.Log("El valor toal del producto es: " + Total123);
        double porcentaje123 = porciento1 + porciento2 + porciento3;
        Debug.Log("Se hizo un descuento de: " + porcentaje123);
    }
}
/*
 * Se pide que se ingrese por inspector:
. Los nombre de tres productos
. Los precios de cada producto
. La cantidad de unidades deseada de cada producto

El programa debe cumplir los siguientes requerimientos:

Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades del mismo supera las 3. 

El programa debe devolver un mensaje de error descriptivo si el precio del producto o la cantidad de unidades son menores a 1.

El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto total sin descuento, el monto de los descuentos aplicados y el total con los descuentos aplicados.

*/