using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    public int numInicial;
    public int numFinal;

    // Start is called before the first frame update
    void Start()
    {
        if (numFinal > numInicial)
        {
            while(numFinal > numInicial)
            {
                Debug.Log(numFinal);
                numFinal--;
            }
        }else if (numFinal == numInicial)
        {
            Debug.Log("Los numeros no pueden ser iguales");
        }
        else
        {
            Debug.Log("El numero inicial no puede ser mas grande que el numero final");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
