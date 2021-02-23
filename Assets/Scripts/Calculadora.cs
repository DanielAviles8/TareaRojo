using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public float Magnitud;
    public GameObject Sphere;
    public float NormalizarX;
    public float NormalizarY;
    public float NormalizarZ;
    public float x1;
    public float y1;
    public float z1;
    public GameObject Cube;
    public float distanciaX;
    public float distanciaY;
    public float distanciaZ;
    public float DistanciaTotal;

    // Start is called before the first frame update
    void Start()
    {
        

        //double res = (Mathf.Sqrt((x * x) + (y * y) + (z * z)));
        //Debug.Log(res);
    }

    // Update is called once per frame
    void Update()
    {
        x = Sphere.transform.position.x;
        y = Sphere.transform.position.y;
        z = Sphere.transform.position.z;
        Magnitud = Mathf.Sqrt((x * x) + (y * y) + (z * z));
        Debug.Log("El Resultado de la Magnitud es" + Magnitud);

        NormalizarX = x / Magnitud;
        NormalizarY = y / Magnitud;
        NormalizarZ = z / Magnitud;
        //Ya solo me falta distancia :c
        //x1-x2, resultado al cuadrado. Con yz tambien. Sumar 3 resultados

        x1 = Cube.transform.position.x;
        y1 = Cube.transform.position.y;
        z1 = Cube.transform.position.z;

        distanciaX = x - x1;
        distanciaY = y - y1;
        distanciaZ = z - z1;

        DistanciaTotal = (distanciaX * distanciaX) + (distanciaY * distanciaY) + (distanciaZ * distanciaZ);
        Debug.Log(DistanciaTotal);
    }
}
