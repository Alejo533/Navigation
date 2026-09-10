using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExamples : MonoBehaviour
{

    public int[] edades = new int[4];
    public int[] notas;
    public int sumaedades;
    public int cantreprobados;
    public int[] distanciaKM;
    public int CantidadKM;
    // Start is called before the first frame update
    void Start()
    {
        sumaedades = SumaValoresArray(edades);
        cantreprobados = Cantidadreprobados(notas);
        CantidadKM = Kilometros(distanciaKM);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int SumaValoresArray(int[] arr)
    {
        int resultado = 0;

        for (int i = 0; i<arr.Length; i++)
        {
            resultado = resultado + arr[1];

        }

        return resultado;
    }

    int Cantidadreprobados(int[] valores)
    {
        int reprobados = 0;

        for (int i = 0; i<valores.Length; i++)
        {
           if (valores[i] < 6)
            {
                reprobados++;
            }
        }

        return reprobados;

    }

    int Kilometros (int[] Dinero)
    {
        int Distancia = 0;

        for (int i = 0; i < Dinero.Length; i++)
        {
            if (Dinero[i] > 100)
            {
                Distancia++;
            }
        }

        return Distancia;

    }
}
