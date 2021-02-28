using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorCruzado : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Vector3 cross1 = new Vector3(4, 6, 8);
        Vector3 cross2 = new Vector3(6, 9, 10);
        Debug.Log("Vector Cruzado" + Ejercicio(cross1, cross2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Vector3 Ejercicio(Vector3 a, Vector3 b)
    {
        Vector3 cruzado;
        cruzado.x =(a.y * b.z) - (a.z * b.y);
        cruzado.y =(a.z * b.x) - (a.x * b.z);
        cruzado.z =(a.x * b.y) - (a.y * b.x);

        return cruzado;
    }
}
