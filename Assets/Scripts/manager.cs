using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour

{
    public Transform spawnPoint1;
    public Transform spawnPoint2;

    public int dinero = 100;

    public GameObject[] productos;

    GameObject obj1;
    GameObject obj2;

    public Text presupuesto;
    public Text pr1;
    public Text pr2;

    public GameObject panel;
    public Text resultado;

    private int sumaProductos;

    void Start()
    {
        obj1 = Instantiate(productos[Random.Range(0, productos.Length)], spawnPoint1.position, Quaternion.identity);


        obj2 = Instantiate(productos[Random.Range(0, productos.Length)], spawnPoint2.position, Quaternion.identity);

        int pre1 = obj1.GetComponent<ProductoScript>().precio; // falta corregir


        int pre2 = obj2.GetComponent<ProductoScript>().precio; // falta corregir

        sumaProductos = pre1 + pre2;

        dinero = Random.Range(10, 100);

        presupuesto.text = $"Presupuesto: ${dinero}";
        pr1.text = $"${pr1}";
        pr2.text = $"${pr2}";
    }

    void Verprecio(int a)
    {
        panel.SetActive(true);

        if (a == 1)
        {
            if (dinero > sumaProductos)
            {
                
                resultado.text = "Compraste";
            }
            else
            {
                
                resultado.text = "No alcanza";
            }
        }
        else if (a == 2)
        {
            if (dinero == sumaProductos)
            {
               
                resultado.text = "Compraste";
            }
            else
            {
                
                resultado.text = "No alcanza";
            }
        }
        else if (a == 3)
        {
            if (dinero < sumaProductos)
            {
              
                resultado.text = "Compraste";
            }
            else
            {
          
                resultado.text = "No Alcanza";
            }
        }
    }

    public void ExcederValor()
    {
        Debug.Log("Sobra");
        Verprecio(1);
    }

    public void Alcanza()
    {
        Debug.Log("Le alcanza para el producto");
        Verprecio(2);
    }

    public void NoLlega()
    {
        Verprecio(3);
    }
}