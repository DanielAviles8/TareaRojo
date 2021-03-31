using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCube : MonoBehaviour
{
    public Material material;

    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;

    Vector3[] vertex;



    int[] triangles;

    List<int> triangles_2;
    // Start is called before the first frame update
    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();

        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        meshRenderer.material = material;

        meshFilter.mesh = mesh;

        vertex = new[]
        {
            new Vector3(0,0,0), //0
            new Vector3(0,1,0), //1
            new Vector3(1,0,0), //2
            new Vector3(1,1,0), //3
            new Vector3(0,0,1), //4
            new Vector3(0,1,1), //5
            new Vector3(1,0,1), //6
            new Vector3(1,1,1), //7
        };

       

        meshFilter.mesh.vertices = vertex;

        triangles = new[]
        {
            0,1,2,  // T_1
            1,3,2,  // T_2
            1,0,4, //T_3
            5,1,4, //T_4
            7,5,4, //T_5
            4,6,7, //T_6
            0,2,4, //T_7
            2,6,4, //T_8
            5,6,7, //T_9
            4,6,5, //T_10
            1,5,3, //T_11
            5,7,3, //T_12
        };

        meshFilter.mesh.triangles = triangles;

    }

}