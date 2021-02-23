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


    // Start is called before the first frame update
    void Start()
    {
        x = Sphere.transform.position.x;
        y = Sphere.transform.position.y;
        z = Sphere.transform.position.z;
        Magnitud = Mathf.Sqrt((x * x) + (y * y) + (z * z));
        Debug.Log("El Resultado de la Magnitud es" +  Magnitud);

        //double res = (Mathf.Sqrt((x * x) + (y * y) + (z * z)));
        //Debug.Log(res);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
