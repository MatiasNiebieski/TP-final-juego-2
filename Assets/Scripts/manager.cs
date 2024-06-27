using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public Text precio1text;
    public Text precio2text;

    public Text platatext;

    public Transform spawn1;
    public Transform spawn2;

    public GameObject[] objetos;

    int plata;
    int precio1;
    int precio2;

    void Start()
    {
        plata = Random.Range(100, 1000);
        platatext.text = plata + "$";

        int index = Random.Range(0, objetos.Length);
        Instantiate(objetos[index], spawn1.position, Quaternion.identity);

        index = Random.Range(0, objetos.Length);
        Instantiate(objetos[index], spawn2.position, Quaternion.identity);   



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
