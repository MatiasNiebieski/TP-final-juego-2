using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public Transform spawnPoint1;
    public Transform spawnPoint2;

    public int dinero = 100;

    public GameObject[] productos;

    GameObject obj1;
    GameObject obj2;

    public Text presupuesto;
    public Text pre1;
    public Text pre2;

    public GameObject pan;
    public Text result;

    private int sumaProductos;

    void Start()
    {
        iniciarJuego();
    }

    public void iniciarJuego()
    {
        pan.SetActive(false);
        obj1 = Instantiate(productos[Random.Range(0, productos.Length)], spawnPoint1.position, Quaternion.identity);
        obj2 = Instantiate(productos[Random.Range(0, productos.Length)], spawnPoint2.position, Quaternion.identity);

        int costo1 = obj1.GetComponent<Productoscript>().precio;
        int costo2 = obj2.GetComponent<Productoscript>().precio;

        sumaProductos = costo1 + costo2;
        dinero = Random.Range(10, 100);
        presupuesto.text = $"Presupuesto: ${dinero}";
        pre1.text = $"${costo1}";
        pre2.text = $"${costo2}";
    }

    void revisar(int a)
    {
        pan.SetActive(true);
        if (a == 1)
        {
            if (dinero > sumaProductos)
            {
               
                result.text = "Ganaste";
            }
            else
            {
                
                result.text = "Perdiste";
            }
        }
        else if (a == 2)
        {
            if (dinero == sumaProductos)
            {
              
                result.text = "Ganaste";
            }
            else
            {
             
                result.text = "Perdiste";
            }
        }
        else if (a == 3)
        {
            if (dinero < sumaProductos)
            {
                
                result.text = "Ganaste";
            }
            else
            {
                
                result.text = "Perdiste";
            }
        }
    }

    public void saldovuelt()
    {
        Debug.Log("comprado y vuelto");
        revisar(1);
    }

    public void saldosuf()
    {
        Debug.Log("Comprado");
        revisar(2);
    }

    public void saldoins()
    {
        Debug.Log("no es posible Comprarlo");
        revisar(3);
    }
}