using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Make10SideCube : MonoBehaviour
{
    public Material material;

    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;

    Vector3[] vertex;
    public Texture texture;
    int[] triangles;
    // Start is called before the first frame update
    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = material;
        //Mesh mesh = GetComponent<MeshFilter>().mesh;

        meshFilter.mesh = mesh;
        //float size = 1f;
        vertex = new[]
                {
            new Vector3(1f, 0, 0), //A0
            new Vector3(2f, 0, 0), //B1
            new Vector3(1.5f, 0.87f, 0), //D2
            new Vector3(1.5f, 0.65f, 0.58f), //E3
            new Vector3(2.31f, 0.76f, 0.58f), //F4
            new Vector3(0.69f, 0.76f, 0.58f), //G5
            new Vector3(0.69f, -0.18f, 0.93f), //H6
            new Vector3(2.31f, -0.18f, 0.93f), //I7
            new Vector3(1.5f, 1.22f, 0.93f), //J8
            new Vector3(1.5f, -0.29f, 1.51f), //K9
            new Vector3(2, 0.58f, 1.51f), //L10
            new Vector3(1, 0.58f, 1.51f), //M11
            };



        meshFilter.mesh.vertices = vertex;

        int[] triangles = {
            
            //0, 1, 2, //base
			//0, 1, 3, //back base
            /*0, 3, 6, //back base left
			1, 3, 7, //back base right
            0, 5, 6, //middle left
			1, 4, 7, //middle right
            0, 2, 5, //almost front left
			1, 2, 4, //almost front right
            2, 5, 8, //front left
			2, 4, 8, //front right
            9, 10, 11, //top
            8, 9, 11, //back top
            4, 8, 10, // back top left
            5, 8, 11, //back top right
            4, 7, 10, //middle top left
            5, 6, 11, //middle top right
            7, 9, 10, //almost front top left
            6, 9, 11, //almost front top right
            3, 7, 9, //front top left
			3, 6, 9 //front top right
            */
        };
        /*
        Vector2[] uvs = {
            new Vector2(0, 0.66f),
            new Vector2(0.25f, 0.66f),
            new Vector2(0, 0.33f),
            new Vector2(0.25f, 0.33f),

            new Vector2(0.5f, 0.66f),
            new Vector2(0.5f, 0.33f),
            new Vector2(0.75f, 0.66f),
            new Vector2(0.75f, 0.33f),

            new Vector2(1, 0.66f),
            new Vector2(1, 0.33f),

            new Vector2(0.25f, 1),
            new Vector2(0.5f, 1),

            new Vector2(0.25f, 0),
            new Vector2(0.5f, 0),
        };
        */
        meshFilter.mesh.triangles = triangles;
    }

}
