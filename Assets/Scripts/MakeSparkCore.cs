using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSparkCore : MonoBehaviour
{
    public Material coreMaterial;

    Mesh coreMesh;
    MeshRenderer coreMeshRenderer;
    MeshFilter coreMeshFilter;

    Vector3[] coreVertex;
    int[] coreTriangles;
    // Start is called before the first frame update
    void Start()
    {
        coreMeshFilter = gameObject.AddComponent<MeshFilter>();
        coreMeshRenderer = gameObject.AddComponent<MeshRenderer>();
        coreMeshRenderer.material = coreMaterial;
        coreMeshFilter.mesh = coreMesh;

        coreVertex = new[]
        {
            //Circulo superior (nivel 1)
            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //0 PuntaSuperior
            new Vector3(-0.001183f, -0.334709f, 1.50085f),      //1 00 L1
            new Vector3(-0.105899f, -0.310808f, 1.50085f),      //2 01 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //3 PuntaSuperior
            new Vector3(-0.105899f, -0.310808f, 1.50085f),      //4 01 L1
            new Vector3(-0.189874f, -0.24384f, 1.50085f),       //5 02 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //6 PuntaSuperior
            new Vector3(-0.189874f, -0.24384f, 1.50085f),       //7 02 L1
            new Vector3(-0.236478f, -0.147067f, 1.50085f),      //8 03 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //9 PuntaSuperior
            new Vector3(-0.236478f, -0.147067f, 1.50085f),      //10 03 L1
            new Vector3(-0.236478f, -0.039658f, 1.50085f),      //11 04 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //12 PuntaSuperior
            new Vector3(-0.236478f, -0.039658f, 1.50085f),      //13 04 L1
            new Vector3(-0.189874f, 0.057114f, 1.50085f),       //14 05 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //15 PuntaSuperior
            new Vector3(-0.189874f, 0.057114f, 1.50085f),       //16 05 L1
            new Vector3(-0.105899f, 0.124082f, 1.50085f),       //17 06 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //18 PuntaSuperior
            new Vector3(-0.105899f, 0.124082f, 1.50085f),       //19 06 L1
            new Vector3(-0.001183f, 0.147983f, 1.50085f),       //20 07 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //21 PuntaSuperior
            new Vector3(-0.001183f, 0.147983f, 1.50085f),       //22 07 L1
            new Vector3(0.103534f, 0.124082f, 1.50085f),        //23 08 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //24 PuntaSuperior
            new Vector3(0.103534f, 0.124082f, 1.50085f),        //25 08 L1
            new Vector3(0.187509f, 0.057114f, 1.50085f),        //26 09 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //27 PuntaSuperior
            new Vector3(0.187509f, 0.057114f, 1.50085f),        //28 09 L1
            new Vector3(0.234112f, -0.039658f, 1.50085f),       //29 10 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //30 PuntaSuperior
            new Vector3(0.234112f, -0.039658f, 1.50085f),       //31 10 L1
            new Vector3(0.234112f, -0.147067f, 1.50085f),       //32 11 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //33 PuntaSuperior
            new Vector3(0.234112f, -0.147067f, 1.50085f),       //34 11 L1
            new Vector3(0.187509f, -0.24384f, 1.50085f),        //35 12 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //36 PuntaSuperior
            new Vector3(0.187509f, -0.24384f, 1.50085f),        //37 12 L1
            new Vector3(0.103534f, -0.310808f, 1.50085f),       //38 13 L1

            new Vector3(-0.001183f, -0.093363f, 1.55593f),      //39 PuntaSuperior
            new Vector3(0.103534f, -0.310808f, 1.50085f),       //40 13 L1
            new Vector3(-0.001183f, -0.334709f, 1.50085f),      //41 00 L1

            //Nivel 2
            new Vector3(-0.001183f, -0.334709f, 1.50085f),      //42 00 L1
            new Vector3(-0.105899f, -0.310808f, 1.50085f),      //43 01 L1
            new Vector3(-0.001183f, -0.528253f, 1.3465f),       //44 00 L2

            new Vector3(-0.001183f, -0.528253f, 1.3465f),       //46 00 L2
            new Vector3(-0.105899f, -0.310808f, 1.50085f),      //45 01 L1
            new Vector3(-0.189875f, -0.485185f, 1.3465f),       //47 01 L2

            new Vector3(-0.105899f, -0.310808f, 1.50085f),      //48 01 L1
            new Vector3(-0.189874f, -0.24384f, 1.50085f),       //49 02 L1
            new Vector3(-0.189875f, -0.485185f, 1.3465f),       //50 01 L2

            new Vector3(-0.189875f, -0.485185f, 1.3465f),       //51 01 L2
            new Vector3(-0.189874f, -0.24384f, 1.50085f),       //52 02 L1
            new Vector3(-0.341193f, -0.364512f, 1.3465f),       //53 02 L2

            new Vector3(-0.189874f, -0.24384f, 1.50085f),       //54 02 L1
            new Vector3(-0.236478f, -0.147067f, 1.50085f),      //55 03 L1
            new Vector3(-0.341193f, -0.364512f, 1.3465f),       //56 02 L2

            new Vector3(-0.341193f, -0.364512f, 1.3465f),       //57 02 L2
            new Vector3(-0.236478f, -0.147067f, 1.50085f),      //58 03 L1
            new Vector3(-0.425169f, -0.190135f, 1.3465f),       //59 03 L2

            new Vector3(-0.236478f, -0.147067f, 1.50085f),      //60 03 L1
            new Vector3(-0.236478f, -0.039658f, 1.50085f),      //61 04 L1
            new Vector3(-0.425169f, -0.190135f, 1.3465f),       //62 03 L2

            new Vector3(-0.425169f, -0.190135f, 1.3465f),       //63 03 L2
            new Vector3(-0.236478f, -0.039658f, 1.50085f),      //64 04 L1
            new Vector3(-0.425169f, -0.00341f, 1.3465f),        //65 04 L2

            new Vector3(-0.236478f, -0.039658f, 1.50085f),      //66 04 L1
            new Vector3(-0.189874f, 0.057114f, 1.50085f),       //67 05 L1
            new Vector3(-0.425169f, 0.00341f, 1.3465f),         //68 04 L2

            new Vector3(-0.425169f, 0.00341f, 1.3465f),         //69 04 L2
            new Vector3(-0.189874f, 0.057114f, 1.50085f),       //70 05 L1
            new Vector3(-0.341193f, 0.177787f, 1.3465f),        //71 05 L2

            new Vector3(-0.189874f, 0.057114f, 1.50085f),       //72 05 L1
            new Vector3(-0.105899f, 0.124082f, 1.50085f),       //73 06 L1
            new Vector3(-0.341193f, 0.177787f, 1.3465f),        //74 05 L2

            new Vector3(-0.341193f, 0.177787f, 1.3465f),        //75 05 L2
            new Vector3(-0.105899f, 0.124082f, 1.50085f),       //76 06 L1
            new Vector3(-0.189874f, 0.29846f, 1.3465f),         //77 06 L2
            
            new Vector3(-0.105899f, 0.124082f, 1.50085f),       //78 06 L1
            new Vector3(-0.001183f, 0.147983f, 1.50085f),       //79 07 L1
            new Vector3(-0.189874f, 0.29846f, 1.3465f),         //80 06 L2

            new Vector3(-0.189874f, 0.29846f, 1.3465f),         //81 06 L2
            new Vector3(-0.001183f, 0.147983f, 1.50085f),       //82 07 L1
            new Vector3(-0.001182f, 0.341527f, 1.3465f),        //83 07 L2

            new Vector3(-0.001183f, 0.147983f, 1.50085f),       //84 07 L1
            new Vector3(0.103534f, 0.124082f, 1.50085f),        //85 08 L1
            new Vector3(-0.001182f, 0.341527f, 1.3465f),        //86 07 L2

            new Vector3(-0.001182f, 0.341527f, 1.3465f),        //87 07 L2
            new Vector3(0.103534f, 0.124082f, 1.50085f),        //88 08 L1
            new Vector3(0.187509f, 0.29846f, 1.3465f),          //89 08 L2

            new Vector3(0.103534f, 0.124082f, 1.50085f),        //90 08 L1
            new Vector3(0.187509f, 0.057114f, 1.50085f),        //91 09 L1
            new Vector3(0.187509f, 0.29846f, 1.3465f),          //92 08 L2

            new Vector3(0.187509f, 0.29846f, 1.3465f),          //93 08 L2
            new Vector3(0.187509f, 0.057114f, 1.50085f),        //94 09 L1
            new Vector3(0.338828f, 0.177787f, 1.3465f),         //95 09 L2
            
            new Vector3(0.187509f, 0.057114f, 1.50085f),        //96 09 L1
            new Vector3(0.234112f, -0.039658f, 1.50085f),       //97 10 L1
            new Vector3(0.338828f, 0.177787f, 1.3465f),         //98 09 L2

            new Vector3(0.338828f, 0.177787f, 1.3465f),         //99  09 L2
            new Vector3(0.234112f, -0.039658f, 1.50085f),       //100 10 L1
            new Vector3(0.422804f, 0.003409f, 1.3465f),         //101 10 L2

            new Vector3(0.234112f, -0.039658f, 1.50085f),       //102 10 L1
            new Vector3(0.234112f, -0.147067f, 1.50085f),       //103 11 L1
            new Vector3(0.422804f, 0.003409f, 1.3465f),         //104 10 L2

            new Vector3(0.422804f, 0.003409f, 1.3465f),         //105 10 L2
            new Vector3(0.234112f, -0.147067f, 1.50085f),       //106 11 L1
            new Vector3(0.422804f, -0.190135f, 1.3465f),        //107 11 L2

            new Vector3(0.234112f, -0.147067f, 1.50085f),       //108 11 L1
            new Vector3(0.187509f, -0.24384f, 1.50085f),        //109 12 L1
            new Vector3(0.422804f, -0.190135f, 1.3465f),        //110 11 L2

            new Vector3(0.422804f, -0.190135f, 1.3465f),        //111 11 L2
            new Vector3(0.187509f, -0.24384f, 1.50085f),        //112 12 L1
            new Vector3(0.338828f, -0.364513f, 1.3465f),        //113 12 L2

            new Vector3(0.187509f, -0.24384f, 1.50085f),        //114 12 L1
            new Vector3(0.103534f, -0.310808f, 1.50085f),       //115 13 L1
            new Vector3(0.338828f, -0.364513f, 1.3465f),        //116 12 L2

            new Vector3(0.338828f, -0.364513f, 1.3465f),        //117 12 L2
            new Vector3(0.103534f, -0.310808f, 1.50085f),       //118 13 L1
            new Vector3(0.187509f, -0.485185f, 1.3465f),        //119 13 L2

            new Vector3(0.103534f, -0.310808f, 1.50085f),       //120 13 L1
            new Vector3(-0.001183f, -0.334709f, 1.50085f),      //121 00 L1
            new Vector3(0.187509f, -0.485185f, 1.3465f),        //122 13 L2

            new Vector3(0.187509f, -0.485185f, 1.3465f),        //123 13 L2
            new Vector3(-0.001183f, -0.334709f, 1.50085f),      //124 00 L1
            new Vector3(-0.001183f, -0.528253f, 1.3465f),       //125 00 L2
        };

        coreMeshFilter.mesh.vertices = coreVertex;

        coreTriangles = new[]
        {
            1, 0, 2,        //00-01 primer anillo
            4, 3, 5,        //01-02 primer anillo
            7, 6, 8,        //02-03 primer anillo
            10, 9, 11,      //03-04 primer anillo
            13, 12, 14,     //04-05 primer anillo
            16, 15, 17,     //05-06 primer anillo
            19, 18, 20,     //06-07 primer anillo
            22, 21, 23,     //07-08 primer anillo
            25, 24, 26,     //08-09 primer anillo
            28, 27, 29,     //09-10 primer anillo
            31, 30, 32,     //10-11 primer anillo
            34, 33, 35,     //11-12 primer anillo
            37, 36, 38,     //12-13 primer anillo
            40, 39, 41,     //13-00 primer anillo

            42, 43, 44,     //00-01 segundo anillo1
            45, 46, 47,     //00-01 segundo anillo2
            48, 49, 50,     //01-02 segundo anillo1
            51, 52, 53,     //01-02 segundo anillo2
            54, 55, 56,     //02-03 segundo anillo1
            57, 58, 59,     //02-03 segundo anillo2
            60, 61, 62,     //03-04 segundo anillo1
            63, 64, 65,     //03-04 segundo anillo2
            66, 67, 68,     //04-05 segundo anillo1
            69, 70, 71,     //04-05 segundo anillo2
            72, 73, 74,     //05-06 segundo anillo1
            75, 76, 77,     //05-06 segundo anillo2
            78, 79, 80,     //06-07 segundo anillo1
            81, 82, 83,     //06-07 segundo anillo2
            84, 85, 86,     //07-08 segundo anillo1
            87, 88, 89,     //07-08 segundo anillo2
            90, 91, 92,     //08-09 segundo anillo1
            93, 94, 95,     //08-09 segundo anillo2
            96, 97, 98,     //09-10 segundo anillo1
            99, 100, 101,   //09-10 segundo anillo2
            102, 103, 104,  //10-11 segundo anillo1
            105, 106, 107,  //10-11 segunso anillo2
            108, 109, 110,  //11-12 segundo anillo1
            111, 112, 113,  //11-12 segundo anillo2
            114, 115, 116,  //12-13 segundo anillo1
            117, 118, 119,  //12-13 segundo anillo2
            120, 121, 122,  //13-00 segundo anillo1
            123, 124, 125,  //13-00 segundo anillo2
        };

        coreMeshFilter.mesh.triangles = coreTriangles;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
