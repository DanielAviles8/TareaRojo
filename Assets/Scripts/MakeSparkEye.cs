using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSparkEye : MonoBehaviour
{
    public Material eyeMaterial;

    Mesh mesh;
    MeshRenderer meshRenderer;
    MeshFilter meshFilter;

    Vector3[] eyeVertex;
    int[] eyeTriangles;

    Vector3 temporalPosition;
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = eyeMaterial;
        meshFilter.mesh = mesh;

        eyeVertex = new[]
        {
            //circulo pequeño del frente
            
            new Vector3(0, -0.83482f, 1.439f),             //1 00
            new Vector3(-0.000015f, -0.835611f, 1.02942f), //0 centro circulo pequeño frente
            new Vector3(0.243459f, -0.83482f, 1.35989f),   //2 01
            
            new Vector3(0.243459f, -0.83482f, 1.35989f),   //4 01
            new Vector3(-0.000015f, -0.835611f, 1.02942f), //0 centro circulo pequeño frente
            new Vector3(0.393925f, -0.83482f, 1.15279f),   //5 02

            new Vector3(0.393925f, -0.83482f, 1.15279f),   //7 02
            new Vector3(-0.000015f, -0.835611f, 1.02942f), //0 centro circulo pequeño frente
            new Vector3(0.393925f, -0.83482f, 0.896806f),  //8 03

            new Vector3(0.393925f, -0.83482f, 0.896806f),  //10 03
            new Vector3(-0.000015f, -0.835611f, 1.02942f), //0 centro circulo pequeño frente
            new Vector3(0.243459f, -0.83482f, 0.689707f),  //11 04

            new Vector3(0.243459f, -0.83482f, 0.689707f),  //13 04
            new Vector3(-0.000015f, -0.835611f, 1.02942f), //0 centro circulo pequeño frente
            new Vector3(0, -0.83482f, 0.610602f),          //14 05

            new Vector3(0, -0.83482f, 0.610602f),          //16 05
            new Vector3(-0.000015f, -0.835611f, 1.02942f), //0 centro circulo pequeño frente
            new Vector3(-0.243459f, -0.83482f, 0.689707f), //17 06

            new Vector3(-0.243459f, -0.83482f, 0.689707f), //19 06
            new Vector3(-0.000015f, -0.835611f, 1.02942f), //0 centro circulo pequeño frente
            new Vector3(-0.393925f, -0.83482f, 0.896806f), //20 07

            new Vector3(-0.393925f, -0.83482f, 0.896806f), //22 07
            new Vector3(-0.000015f, -0.835611f, 1.02942f), //0 centro circulo pequeño frente
            new Vector3(-0.393925f, -0.83482f, 1.15279f),  //23 08

            new Vector3(-0.393925f, -0.83482f, 1.15279f),  //25 08
            new Vector3(-0.000015f, -0.835611f, 1.02942f), //0 centro circulo pequeño frente
            new Vector3(-0.243459f, -0.83482f, 1.35989f),  //26 09

            new Vector3(-0.243459f, -0.83482f, 1.35989f),  //28 09
            new Vector3(-0.000015f, -0.835611f, 1.02942f), //0 centro circulo pequeño frente
            new Vector3(0, -0.83482f, 1.439f),             //29 00

            //primer circulo grande conectado al pequeño del frente
            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //30 centro primer circulo grande
            new Vector3(0.000854f, -0.78039f, 1.5485f),    //31 00
            new Vector3(0.305975f, -0.78039f, 1.44936f),   //32 01

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //33 centro primer circulo grande
            new Vector3(0.305975f, -0.78039f, 1.44936f),   //34 01
            new Vector3(0.49455f, -0.78039f, 1.18981f),    //35 02

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //36 centro primer circulo grande
            new Vector3(0.49455f, -0.78039f, 1.18981f),    //37 02
            new Vector3(0.49455f, -0.78039f, 0.868988f),   //38 03

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //39 centro primer circulo grande
            new Vector3(0.49455f, -0.78039f, 0.868988f),   //40 03
            new Vector3(0.305975f, -0.78039f, 0.609437f),  //41 04

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //42 centro primer circulo grande
            new Vector3(0.305975f, -0.78039f, 0.609437f),  //43 04
            new Vector3(0.000854f, -0.78039f, 0.510297f),  //44 05

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //45 centro primer circulo grande
            new Vector3(0.000854f, -0.78039f, 0.510297f),  //46 05
            new Vector3(-0.304267f, -0.78039f, 0.609437f), //47 06

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //48 centro primer circulo grande
            new Vector3(-0.304267f, -0.78039f, 0.609437f), //49 06
            new Vector3(-0.492842f, -0.78039f, 0.868988f), //50 07

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //51 centro primer circulo grande
            new Vector3(-0.492842f, -0.78039f, 0.868988f), //52 07
            new Vector3(-0.492842f, -0.78039f, 1.18981f),  //53 08

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //54 centro primer circulo grande
            new Vector3(-0.492842f, -0.78039f, 1.18981f),  //55 08
            new Vector3(-0.304267f, -0.78039f, 1.44936f),  //56 09

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //57 centro primer circulo grande
            new Vector3(-0.304267f, -0.78039f, 1.44936f),  //58 09
            new Vector3(0.000854f, -0.78039f, 1.5485f),    //59 00

            //Conexión entre circulo pequeño y grande
            new Vector3(0.000854f, -0.78039f, 1.5485f),    //60 grande 00
            new Vector3(0, -0.83482f, 1.439f),             //61 pequeño 00
            new Vector3(0.243459f, -0.83482f, 1.35989f),   //62 pequeño 01

            new Vector3(0.000854f, -0.78039f, 1.5485f),    //63 grande 00
            new Vector3(0.243459f, -0.83482f, 1.35989f),   //64 pequeño 01
            new Vector3(0.305975f, -0.78039f, 1.44936f),   //65 grande 01

            new Vector3(0.305975f, -0.78039f, 1.44936f),   //66 grande 01
            new Vector3(0.243459f, -0.83482f, 1.35989f),   //67 pequeño 01
            new Vector3(0.393925f, -0.83482f, 1.15279f),   //68 pequeño 02

            new Vector3(0.305975f, -0.78039f, 1.44936f),   //69 grande 01
            new Vector3(0.49455f, -0.78039f, 1.18981f),    //70 grande 02
            new Vector3(0.393925f, -0.83482f, 1.15279f),   //71 pequeño 02

            new Vector3(0.49455f, -0.78039f, 1.18981f),    //72 grande 02
            new Vector3(0.393925f, -0.83482f, 1.15279f),   //73 pequeño 02
            new Vector3(0.393925f, -0.83482f, 0.896806f),  //74 pequeño 03

            new Vector3(0.49455f, -0.78039f, 1.18981f),    //75 grande 02
            new Vector3(0.393925f, -0.83482f, 0.896806f),  //76 pequeño 03
            new Vector3(0.49455f, -0.78039f, 0.868988f),   //77 grande 03

            new Vector3(0.49455f, -0.78039f, 0.868988f),   //78 grande 03
            new Vector3(0.393925f, -0.83482f, 0.896806f),  //79 pequeño 03
            new Vector3(0.243459f, -0.83482f, 0.689707f),  //80 pequeño 04

            new Vector3(0.49455f, -0.78039f, 0.868988f),   //81 grande 03
            new Vector3(0.243459f, -0.83482f, 0.689707f),  //82 pequeño 04
            new Vector3(0.305975f, -0.78039f, 0.609437f),  //83 grande 04

            new Vector3(0.305975f, -0.78039f, 0.609437f),  //84 grande 04
            new Vector3(0.243459f, -0.83482f, 0.689707f),  //85 pequeño 04
            new Vector3(0, -0.83482f, 0.610602f),          //86 pequeño 05

            new Vector3(0.305975f, -0.78039f, 0.609437f),  //87 grande 04
            new Vector3(0, -0.83482f, 0.610602f),          //88 pequeño 05
            new Vector3(0.000854f, -0.78039f, 0.510297f),  //89 grande 05

            new Vector3(0.000854f, -0.78039f, 0.510297f),  //90 grande 05
            new Vector3(0, -0.83482f, 0.610602f),          //91 pequeño 05
            new Vector3(-0.243459f, -0.83482f, 0.689707f), //92 pequeño 06

            new Vector3(0.000854f, -0.78039f, 0.510297f),  //93 grande 05
            new Vector3(-0.243459f, -0.83482f, 0.689707f), //94 pequeño 06
            new Vector3(-0.304267f, -0.78039f, 0.609437f), //95 grande 06

            new Vector3(-0.304267f, -0.78039f, 0.609437f), //96 grande 06
            new Vector3(-0.243459f, -0.83482f, 0.689707f), //97 pequeño 06
            new Vector3(-0.393925f, -0.83482f, 0.896806f), //98 pequeño 07

            new Vector3(-0.304267f, -0.78039f, 0.609437f), //99 grande 06
            new Vector3(-0.393925f, -0.83482f, 0.896806f), //100 pequeño 07
            new Vector3(-0.492842f, -0.78039f, 0.868988f), //101 grande 07

            new Vector3(-0.492842f, -0.78039f, 0.868988f), //102 grande 07
            new Vector3(-0.393925f, -0.83482f, 0.896806f), //103 pequeño 07
            new Vector3(-0.393925f, -0.83482f, 1.15279f),  //104 pequeño 08

            new Vector3(-0.492842f, -0.78039f, 0.868988f), //105 grande 07
            new Vector3(-0.393925f, -0.83482f, 1.15279f),  //106 pequeño 08
            new Vector3(-0.492842f, -0.78039f, 1.18981f),  //107 grande 08

            new Vector3(-0.492842f, -0.78039f, 1.18981f),  //108 grande 08
            new Vector3(-0.393925f, -0.83482f, 1.15279f),  //109 pequeño 08
            new Vector3(-0.243459f, -0.83482f, 1.35989f),  //110 pequeño 09

            new Vector3(-0.492842f, -0.78039f, 1.18981f),  //111 grande 08
            new Vector3(-0.243459f, -0.83482f, 1.35989f),  //112 pequeño 09
            new Vector3(-0.304267f, -0.78039f, 1.44936f),  //113 grande 09

            new Vector3(-0.304267f, -0.78039f, 1.44936f),  //114 grande 09
            new Vector3(-0.243459f, -0.83482f, 1.35989f),  //115 pequeño 09
            new Vector3(0, -0.83482f, 1.439f),             //116 pequeño 00

            new Vector3(-0.304267f, -0.78039f, 1.44936f),  //117 grande 09
            new Vector3(0, -0.83482f, 1.439f),             //118 pequeño 00
            new Vector3(0.000854f, -0.78039f, 1.5485f),    //119 grande 00

            //segundo circulo grande (trasero)
            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //120 centro circulo grande
            new Vector3(-0.000015f, -0.72598f, 1.5485f),   //121 T00
            new Vector3(0.305106f, -0.72598f, 1.44936f),   //122 T01

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //123 centro circulo grande
            new Vector3(0.305106f, -0.72598f, 1.44936f),   //124 T01
            new Vector3(0.493681f, -0.72598f, 1.18981f),   //125 T02

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //126 centro circulo grande
            new Vector3(0.493681f, -0.72598f, 1.18981f),   //127 T02
            new Vector3(0.493681f, -0.72598f, 0.868988f),  //128 T03

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //129 centro circulo grande
            new Vector3(0.493681f, -0.72598f, 0.868988f),  //130 T03
            new Vector3(0.305106f, -0.72598f, 0.609437f),  //131 T04

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //132 centro circulo grande
            new Vector3(0.305106f, -0.72598f, 0.609437f),  //133 T04
            new Vector3(0.000854f, -0.725977f, 0.519803f), //134 T05

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //135 centro circulo grande
            new Vector3(0.000854f, -0.725977f, 0.519803f), //136 T05
            new Vector3(-0.305136f, -0.72598f, 0.609437f), //137 T06

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //138 centro circulo grande
            new Vector3(-0.305136f, -0.72598f, 0.609437f), //139 T06
            new Vector3(-0.493711f, -0.72598f, 0.868988f), //140 T07

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //141 centro circulo grande
            new Vector3(-0.493711f, -0.72598f, 0.868988f), //142 T07
            new Vector3(-0.493711f, -0.72598f, 1.18981f),  //143 T08

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //144 centro circulo grande
            new Vector3(-0.493711f, -0.72598f, 1.18981f),  //145 T08
            new Vector3(-0.305136f, -0.72598f, 1.44936f),  //146 T09

            new Vector3(-0.000015f, -0.72598f, 1.0294f),   //147 centro circulo grande
            new Vector3(-0.305136f, -0.72598f, 1.44936f),  //148 T09
            new Vector3(-0.000015f, -0.72598f, 1.5485f),   //149 T00

            //Conecciones (Easter Egg para Ray) entre circulos grandes
            new Vector3(-0.000015f, -0.72598f, 1.5485f),   //150 T00
            new Vector3(0.000854f, -0.78039f, 1.5485f),    //151 grande 00
            new Vector3(0.305975f, -0.78039f, 1.44936f),   //152 grande 01

            new Vector3(-0.000015f, -0.72598f, 1.5485f),   //153 T00
            new Vector3(0.305975f, -0.78039f, 1.44936f),   //154 grande 01
            new Vector3(0.305106f, -0.72598f, 1.44936f),   //155 T01

            new Vector3(0.305106f, -0.72598f, 1.44936f),   //156 T01
            new Vector3(0.305975f, -0.78039f, 1.44936f),   //157 grande 01
            new Vector3(0.49455f, -0.78039f, 1.18981f),    //158 grande 02

            new Vector3(0.305106f, -0.72598f, 1.44936f),   //159 T01
            new Vector3(0.49455f, -0.78039f, 1.18981f),    //160 grande 02
            new Vector3(0.493681f, -0.72598f, 1.18981f),   //161 T02

            new Vector3(0.493681f, -0.72598f, 1.18981f),   //162 T02
            new Vector3(0.49455f, -0.78039f, 1.18981f),    //163 grande 02
            new Vector3(0.49455f, -0.78039f, 0.868988f),   //164 grande 03

            new Vector3(0.493681f, -0.72598f, 1.18981f),   //165 T02
            new Vector3(0.49455f, -0.78039f, 0.868988f),   //166 grande 03
            new Vector3(0.493681f, -0.72598f, 0.868988f),  //167 T03

            new Vector3(0.493681f, -0.72598f, 0.868988f),  //168 T03
            new Vector3(0.49455f, -0.78039f, 0.868988f),   //169 grande 03
            new Vector3(0.305975f, -0.78039f, 0.609437f),  //170 grande 04

            new Vector3(0.493681f, -0.72598f, 0.868988f),  //171 T03
            new Vector3(0.305975f, -0.78039f, 0.609437f),  //172 grande 04
            new Vector3(0.305106f, -0.72598f, 0.609437f),  //173 T04

            new Vector3(0.305106f, -0.72598f, 0.609437f),  //174 T04
            new Vector3(0.305975f, -0.78039f, 0.609437f),  //175 grande 04
            new Vector3(0.000854f, -0.78039f, 0.510297f),  //176 grande 05

            new Vector3(0.305106f, -0.72598f, 0.609437f),  //177 T04
            new Vector3(0.000854f, -0.78039f, 0.510297f),  //178 grande 05
            new Vector3(0.000854f, -0.725977f, 0.519803f), //179 T05

            new Vector3(0.000854f, -0.725977f, 0.519803f), //180 T05
            new Vector3(0.000854f, -0.78039f, 0.510297f),  //181 grande 05
            new Vector3(-0.304267f, -0.78039f, 0.609437f), //182 grande 06

            new Vector3(0.000854f, -0.725977f, 0.519803f), //183 T05
            new Vector3(-0.304267f, -0.78039f, 0.609437f), //184 grande 06
            new Vector3(-0.305136f, -0.72598f, 0.609437f), //185 T06

            new Vector3(-0.305136f, -0.72598f, 0.609437f), //186 T06
            new Vector3(-0.304267f, -0.78039f, 0.609437f), //187 grande 06
            new Vector3(-0.492842f, -0.78039f, 0.868988f), //188 grande 07

            new Vector3(-0.305136f, -0.72598f, 0.609437f), //189 T06
            new Vector3(-0.492842f, -0.78039f, 0.868988f), //190 grande 07
            new Vector3(-0.493711f, -0.72598f, 0.868988f), //191 T07

            new Vector3(-0.493711f, -0.72598f, 0.868988f), //192 T07
            new Vector3(-0.492842f, -0.78039f, 0.868988f), //193 grande 07
            new Vector3(-0.492842f, -0.78039f, 1.18981f),  //194 grande 08

            new Vector3(-0.493711f, -0.72598f, 0.868988f), //195 T07
            new Vector3(-0.492842f, -0.78039f, 1.18981f),  //196 grande 08
            new Vector3(-0.493711f, -0.72598f, 1.18981f),  //197 T08

            new Vector3(-0.493711f, -0.72598f, 1.18981f),  //198 T08
            new Vector3(-0.492842f, -0.78039f, 1.18981f),  //199 grande 08
            new Vector3(-0.304267f, -0.78039f, 1.44936f),  //200 grande 09

            new Vector3(-0.493711f, -0.72598f, 1.18981f),  //201 T08
            new Vector3(-0.304267f, -0.78039f, 1.44936f),  //202 grande 09
            new Vector3(-0.305136f, -0.72598f, 1.44936f),  //203 T09

            new Vector3(-0.305136f, -0.72598f, 1.44936f),  //204 T09
            new Vector3(-0.304267f, -0.78039f, 1.44936f),  //205 grande 09
            new Vector3(0.000854f, -0.78039f, 1.5485f),    //206 grande 00

            new Vector3(-0.305136f, -0.72598f, 1.44936f),  //207 T09
            new Vector3(0.000854f, -0.78039f, 1.5485f),    //208 grande 00
            new Vector3(-0.000015f, -0.72598f, 1.5485f),   //209 T00

            //Base ojito
            new Vector3(0.000854f, -0.78039f, 0.510297f),  //210 BaseCentroArriba
            new Vector3(-0.194166f, -0.78039f, 0.558595f), //211 BaseIzqArriba
            new Vector3(-0.194161f, -0.780394f, 0.186133f),//212 BaseIzqAbajo

            new Vector3(0.000854f, -0.78039f, 0.510297f),  //213 BaseCentroArriba
            new Vector3(-0.194161f, -0.780394f, 0.186133f),//214 BaseIzqAbajo
            new Vector3(-0.000015f, -0.780394f, 0.153482f),//215 BaseCentroAbajo

            new Vector3(0.000854f, -0.78039f, 0.510297f),  //216 BaseCentroArriba
            new Vector3(0.195874f, -0.780392f, 0.558595f), //217 BaseDerArriba
            new Vector3(0.195873f, -0.780394f, 0.186133f), //218 BaseDerAbajo

            new Vector3(0.000854f, -0.78039f, 0.510297f),  //219 BaseCentroArriba
            new Vector3(0.195873f, -0.780394f, 0.186133f), //220 BaseDerAbajo
            new Vector3(-0.000015f, -0.780394f, 0.153482f),//221 BaseCentroAbajo

            new Vector3(-0.000015f, -0.72598f, 0.510297f), //222 BaseCentroArribaT
            new Vector3(-0.194166f, -0.72598f, 0.558595f), //223 BaseIzqArribaT
            new Vector3(-0.194161f, -0.725974f, 0.186133f),//224 BaseIzqAbajoT

            new Vector3(-0.000015f, -0.72598f, 0.510297f), //225 BaseCentroArribaT
            new Vector3(-0.194161f, -0.725974f, 0.186133f),//226 BaseIzqAbajoT
            new Vector3(-0.000015f, -0.725974f, 0.153482f),//227 BaseCentroAbajoT

            new Vector3(-0.000015f, -0.72598f, 0.510297f), //228 BaseCentroArribaT
            new Vector3(0.195875f, -0.725977f, 0.558595f), //229 BaseDerArribaT
            new Vector3(0.195873f, -0.725974f, 0.186133f), //230 BaseDerAbajoT

            new Vector3(-0.000015f, -0.72598f, 0.510297f), //231 BaseCentroArribaT
            new Vector3(0.195873f, -0.725974f, 0.186133f), //232 BaseDerAbajoT
            new Vector3(-0.000015f, -0.725974f, 0.153482f),//233 BaseCentroAbajoT

            //Conexion de las bases
            new Vector3(-0.194166f, -0.78039f, 0.558595f), //234 BaseIzqArriba
            new Vector3(-0.194161f, -0.780394f, 0.186133f),//235 BaseIzqAbajo
            new Vector3(-0.194161f, -0.725974f, 0.186133f),//236 BaseIzqAbajoT

            new Vector3(-0.194166f, -0.78039f, 0.558595f), //237 BaseIzqArriba
            new Vector3(-0.194166f, -0.72598f, 0.558595f), //238 BaseIzqArribaT
            new Vector3(-0.194161f, -0.725974f, 0.186133f),//239 BaseIzqAbajoT

            new Vector3(-0.194161f, -0.780394f, 0.186133f),//240 BaseIzqAbajo
            new Vector3(-0.194161f, -0.725974f, 0.186133f),//241 BaseIzqAbajoT
            new Vector3(-0.000015f, -0.725974f, 0.153482f),//242 BaseCentroAbajoT

            new Vector3(-0.194161f, -0.780394f, 0.186133f),//243 BaseIzqAbajo
            new Vector3(-0.000015f, -0.725974f, 0.153482f),//244 BaseCentroAbajoT
            new Vector3(-0.000015f, -0.780394f, 0.153482f),//245 BaseCentroAbajo

            new Vector3(-0.000015f, -0.780394f, 0.153482f),//246 BaseCentroAbajo
            new Vector3(-0.000015f, -0.725974f, 0.153482f),//247 BaseCentroAbajoT
            new Vector3(0.195873f, -0.725974f, 0.186133f), //248 BaseDerAbajoT

            new Vector3(-0.000015f, -0.780394f, 0.153482f),//249 BaseCentroAbajo
            new Vector3(0.195873f, -0.725974f, 0.186133f), //250 BaseDerAbajoT
            new Vector3(0.195873f, -0.780394f, 0.186133f), //251 BaseDerAbajo

            new Vector3(0.195873f, -0.780394f, 0.186133f), //252 BaseDerAbajo
            new Vector3(0.195873f, -0.725974f, 0.186133f), //253 BaseDerAbajoT
            new Vector3(0.195875f, -0.725977f, 0.558595f), //254 BaseDerArribaT

            new Vector3(0.195873f, -0.780394f, 0.186133f), //255 BaseDerAbajo
            new Vector3(0.195875f, -0.725977f, 0.558595f), //256 BaseDerArribaT
            new Vector3(0.195874f, -0.780392f, 0.558595f), //257 BaseDerArriba

            new Vector3(0.195874f, -0.780392f, 0.558595f), //258 BaseDerArriba
            new Vector3(0.195875f, -0.725977f, 0.558595f), //259 BaseDerArribaT
            new Vector3(-0.000015f, -0.72598f, 0.510297f), //260 BaseCentroArribaT

            new Vector3(0.195874f, -0.780392f, 0.558595f), //261 BaseDerArriba
            new Vector3(-0.000015f, -0.72598f, 0.510297f), //262 BaseCentroArribaT
            new Vector3(0.000854f, -0.78039f, 0.510297f),  //263 BaseCentroArriba

            new Vector3(0.000854f, -0.78039f, 0.510297f),  //264 BaseCentroArriba
            new Vector3(-0.000015f, -0.72598f, 0.510297f), //265 BaseCentroArribaT
            new Vector3(-0.194166f, -0.72598f, 0.558595f), //266 BaseIzqArribaT

            new Vector3(0.000854f, -0.78039f, 0.510297f),  //267 BaseCentroArriba
            new Vector3(-0.194166f, -0.72598f, 0.558595f), //268 BaseIzqArribaT
            new Vector3(-0.194166f, -0.78039f, 0.558595f), //269 BaseIzqArriba
        };

        meshFilter.mesh.vertices = eyeVertex;

        eyeTriangles = new[]
        {
            0, 1, 2,        //00-01 circulo pequeño
            3, 4, 5,        //01-02 circulo pequeño
            6, 7, 8,        //02-03 circulo pequeño
            9, 10, 11,      //03-04 circulo pequeño
            12, 13, 14,     //04-05 circulo pequeño
            15, 16, 17,     //05-06 circulo pequeño
            18, 19, 20,     //06-07 circulo pequeño
            21, 22, 23,     //07-08 circulo pequeño
            24, 25, 26,     //08-09 circulo pequeño
            27, 28, 29,     //09-00 circulo pequeño

            31, 30, 32,     //00-01 circulo grande
            34, 33, 35,     //01-02 circulo grande
            37, 36, 38,     //02-03 circulo grande
            40, 39, 41,     //03-04 circulo grande
            43, 42, 44,     //04-05 circulo grande
            46, 45, 47,     //05-06 circulo grande
            49, 48, 50,     //06-07 circulo grande
            52, 51, 53,     //07-08 circulo grande
            55, 54, 56,     //08-09 circulo grande
            58, 57, 59,     //09-00 circulo grande

            60, 61, 62,     //G00-P00-P01
            63, 64, 65,     //G01-P01-G01
            66, 67, 68,     //G01-P01-P02
            70, 69, 71,     //G01-G02-P02
            72, 73, 74,     //G02-P02-P03
            75, 76, 77,     //G02-P03-G03
            78, 79, 80,     //G03-P03-P04
            81, 82, 83,     //G03-P04-G04
            84, 85, 86,     //G04-P04-P05
            87, 88, 89,     //G04-P05-G05
            90, 91, 92,     //G05-P05-P06
            93, 94, 95,     //G05-P06-G06
            96, 97, 98,     //G06-P06-P07
            99, 100, 101,   //G06-P07-G07
            102, 103, 104,  //G07-P07-P08
            105, 106, 107,  //G07-P08-G08
            108, 109, 110,  //G08-P08-P09
            111, 112, 113,  //G08-P09-G09
            114, 115, 116,  //G09-P09-P00
            117, 118, 119,  //G09-P00-G00

            120, 121, 122,  //T00-T01
            123, 124, 125,  //T01-T02
            126, 127, 128,  //T02-T03
            129, 130, 131,  //T03-T04
            132, 133, 134,  //T04-T05
            135, 136, 137,  //T05-T06
            138, 139, 140,  //T06-T07
            141, 142, 143,  //T07-T08
            144, 145, 146,  //T08-T09
            147, 148, 149,  //T09-T00

            150, 151, 152,  //T00-G00-G01
            153, 154, 155,  //T00-G01-T01
            156, 157, 158,  //T01-G01-G02
            159, 160, 161,  //T01-G02-T02
            162, 163, 164,  //T02-G02-G03
            165, 166, 167,  //T02-G03-T03
            168, 169, 170,  //T03-G03-G04
            171, 172, 173,  //T03-G04-T04
            174, 175, 176,  //T04-G04-G05
            177, 178, 179,  //T04-G05-T05
            180, 181, 182,  //T05-G05-G06
            183, 184, 185,  //T05-G06-T06
            186, 187, 188,  //T06-G06-G07
            189, 190, 191,  //T06-G07-T07
            192, 193, 194,  //T07-G07-G08
            195, 196, 197,  //T07-G08-T08
            198, 199, 200,  //T08-G08-G09
            201, 202, 203,  //T08-G09-T09
            204, 205, 206,  //T09-G09-G00
            207, 208, 209,  //T09-G00-T00

            210, 211, 212,  //BCAA-BIAA-BIAB
            213, 214, 215,  //BCAA-BIAB-BCAB
            217, 216, 218,  //BCAA-BDAA-BDAB
            220, 219, 221,  //BCAA-BDAB-BCAB
            223, 222, 224,  //BCAAT-BIAAT-BIABT
            226, 225, 227,  //BCAAT-BIABT-BCABT
            228, 229, 230,  //BCAAT-BDAAT-BDABT
            231, 232, 233,  //BCAAT-BDABT-BCABT

            235, 234, 236,  //ConexionIzq1
            237, 238, 239,  //ConexionIzq2
            240, 241, 242,  //ConexionAbajoIzq1
            243, 244, 245,  //ConexionAbajoIzq2
            246, 247, 248,  //ConexionAbajoDer1
            249, 250, 251,  //ConexionAbajoDer2
            252, 253, 254,  //ConexionDer1
            255, 256, 257,  //ConexionDer2
            258, 259, 260,  //ConexionesArribaDer1
            261, 262, 263,  //ConexionesArribaDer2
            264, 265, 266,  //ConexionesArribaIzq1
            267, 268, 269,  //ConexionesArribaIzq2
        };



        Vector2[] eyeUV =
        {
            //circulo pequeño (10 triangulos)
            new Vector2(0.170395869f, 0.015228426f),        //00
            new Vector2(0.170395869f, 0.532994924f),        //Centro
            new Vector2(0.270223752f, 0.121827411f),        //01

            new Vector2(0.270223752f, 0.121827411f),        //01
            new Vector2(0.170395869f, 0.532994924f),        //Centro
            new Vector2(0.325301205f, 0.38071066f),         //02

            new Vector2(0.325301205f, 0.38071066f),         //02
            new Vector2(0.170395869f, 0.532994924f),        //Centro
            new Vector2(0.320137694f, 0.675126904f),        //03

            new Vector2(0.320137694f, 0.675126904f),        //03
            new Vector2(0.170395869f, 0.532994924f),        //Centro
            new Vector2(0.256454389f, 0.903553299f),        //04

            new Vector2(0.256454389f, 0.903553299f),        //04
            new Vector2(0.170395869f, 0.532994924f),        //Centro
            new Vector2(0.168674699f, 0.984771574f),        //05

            new Vector2(0.168674699f, 0.984771574f),        //05
            new Vector2(0.170395869f, 0.532994924f),        //Centro
            new Vector2(0.075731497f, 0.903553299f),        //06

            new Vector2(0.075731497f, 0.903553299f),        //06
            new Vector2(0.170395869f, 0.532994924f),        //Centro
            new Vector2(0.010327022f, 0.695431472f),        //07

            new Vector2(0.010327022f, 0.695431472f),        //07
            new Vector2(0.170395869f, 0.532994924f),        //Centro
            new Vector2(0.008605852f, 0.38071066f),         //08

            new Vector2(0.008605852f, 0.38071066f),         //08
            new Vector2(0.170395869f, 0.532994924f),        //Centro
            new Vector2(0.063683305f, 0.121827411f),        //09

            new Vector2(0.063683305f, 0.121827411f),        //09
            new Vector2(0.170395869f, 0.532994924f),        //Centro
            new Vector2(0.170395869f, 0.015228426f),        //00

            //Circulo grande (10 triangulos) 
            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            //Conexión circulo chico y grande
            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            //Circulo trasero
            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            //Conexión circulos grandes
            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            //Base Ojito
            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            //Base Laterales
            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),

            new Vector2(0.741824441f, 0.989847716f),
            new Vector2(0.547332186f, 0.005076142f),
            new Vector2(0.352839931f, 0.989847716f),
        };

        meshFilter.mesh.triangles = eyeTriangles;
        meshFilter.mesh.uv = eyeUV;
    }

    // Update is called once per frame
    void Update()
    {
        PleaseRotate();
    }
    void PleaseRotate()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        meshFilter.mesh = mesh;

        temporalPosition = this.transform.position;
        this.transform.position = new Vector3(0, 0, 0);

        for(int i = 0; i < eyeVertex.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                eyeVertex[i] = RotateX(eyeVertex[i].x, eyeVertex[i].y, eyeVertex[i].z);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                eyeVertex[i] = RotateY(eyeVertex[i].x, eyeVertex[i].y, eyeVertex[i].z);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                eyeVertex[i] = RotateZ(eyeVertex[i].x, eyeVertex[i].y, eyeVertex[i].z);
            }
        }

        meshFilter.mesh.vertices = eyeVertex;

        eyeTriangles = new[]
        {
            0, 1, 2,        //00-01 circulo pequeño
            3, 4, 5,        //01-02 circulo pequeño
            6, 7, 8,        //02-03 circulo pequeño
            9, 10, 11,      //03-04 circulo pequeño
            12, 13, 14,     //04-05 circulo pequeño
            15, 16, 17,     //05-06 circulo pequeño
            18, 19, 20,     //06-07 circulo pequeño
            21, 22, 23,     //07-08 circulo pequeño
            24, 25, 26,     //08-09 circulo pequeño
            27, 28, 29,     //09-00 circulo pequeño

            31, 30, 32,     //00-01 circulo grande
            34, 33, 35,     //01-02 circulo grande
            37, 36, 38,     //02-03 circulo grande
            40, 39, 41,     //03-04 circulo grande
            43, 42, 44,     //04-05 circulo grande
            46, 45, 47,     //05-06 circulo grande
            49, 48, 50,     //06-07 circulo grande
            52, 51, 53,     //07-08 circulo grande
            55, 54, 56,     //08-09 circulo grande
            58, 57, 59,     //09-00 circulo grande

            60, 61, 62,     //G00-P00-P01
            63, 64, 65,     //G01-P01-G01
            66, 67, 68,     //G01-P01-P02
            70, 69, 71,     //G01-G02-P02
            72, 73, 74,     //G02-P02-P03
            75, 76, 77,     //G02-P03-G03
            78, 79, 80,     //G03-P03-P04
            81, 82, 83,     //G03-P04-G04
            84, 85, 86,     //G04-P04-P05
            87, 88, 89,     //G04-P05-G05
            90, 91, 92,     //G05-P05-P06
            93, 94, 95,     //G05-P06-G06
            96, 97, 98,     //G06-P06-P07
            99, 100, 101,   //G06-P07-G07
            102, 103, 104,  //G07-P07-P08
            105, 106, 107,  //G07-P08-G08
            108, 109, 110,  //G08-P08-P09
            111, 112, 113,  //G08-P09-G09
            114, 115, 116,  //G09-P09-P00
            117, 118, 119,  //G09-P00-G00

            120, 121, 122,  //T00-T01
            123, 124, 125,  //T01-T02
            126, 127, 128,  //T02-T03
            129, 130, 131,  //T03-T04
            132, 133, 134,  //T04-T05
            135, 136, 137,  //T05-T06
            138, 139, 140,  //T06-T07
            141, 142, 143,  //T07-T08
            144, 145, 146,  //T08-T09
            147, 148, 149,  //T09-T00

            150, 151, 152,  //T00-G00-G01
            153, 154, 155,  //T00-G01-T01
            156, 157, 158,  //T01-G01-G02
            159, 160, 161,  //T01-G02-T02
            162, 163, 164,  //T02-G02-G03
            165, 166, 167,  //T02-G03-T03
            168, 169, 170,  //T03-G03-G04
            171, 172, 173,  //T03-G04-T04
            174, 175, 176,  //T04-G04-G05
            177, 178, 179,  //T04-G05-T05
            180, 181, 182,  //T05-G05-G06
            183, 184, 185,  //T05-G06-T06
            186, 187, 188,  //T06-G06-G07
            189, 190, 191,  //T06-G07-T07
            192, 193, 194,  //T07-G07-G08
            195, 196, 197,  //T07-G08-T08
            198, 199, 200,  //T08-G08-G09
            201, 202, 203,  //T08-G09-T09
            204, 205, 206,  //T09-G09-G00
            207, 208, 209,  //T09-G00-T00

            210, 211, 212,  //BCAA-BIAA-BIAB
            213, 214, 215,  //BCAA-BIAB-BCAB
            217, 216, 218,  //BCAA-BDAA-BDAB
            220, 219, 221,  //BCAA-BDAB-BCAB
            223, 222, 224,  //BCAAT-BIAAT-BIABT
            226, 225, 227,  //BCAAT-BIABT-BCABT
            228, 229, 230,  //BCAAT-BDAAT-BDABT
            231, 232, 233,  //BCAAT-BDABT-BCABT

            235, 234, 236,  //ConexionIzq1
            237, 238, 239,  //ConexionIzq2
            240, 241, 242,  //ConexionAbajoIzq1
            243, 244, 245,  //ConexionAbajoIzq2
            246, 247, 248,  //ConexionAbajoDer1
            249, 250, 251,  //ConexionAbajoDer2
            252, 253, 254,  //ConexionDer1
            255, 256, 257,  //ConexionDer2
            258, 259, 260,  //ConexionesArribaDer1
            261, 262, 263,  //ConexionesArribaDer2
            264, 265, 266,  //ConexionesArribaIzq1
            267, 268, 269,  //ConexionesArribaIzq2
        };

        meshFilter.mesh.triangles = eyeTriangles;
        this.transform.position = temporalPosition;
    }
     Vector3 RotateX(float x, float y, float z)
    {
        Vector3 pos1 = new Vector3(x, y, z);
        float yPrime = (pos1.y * Mathf.Cos(angle)) - (pos1.z * Mathf.Sin(angle));
        float zPrime = (pos1.y * Mathf.Sin(angle)) - (pos1.z * Mathf.Cos(angle));

        return new Vector3(pos1.x, yPrime, zPrime);
    }
    Vector3 RotateY(float x, float y, float z)
    {
        Vector3 pos2 = new Vector3(x, y, z);
        float zPrime = (pos2.z * Mathf.Cos(angle)) - (pos2.x * Mathf.Sin(angle));
        float xPrime = (pos2.z * Mathf.Sin(angle)) - (pos2.x * Mathf.Cos(angle));

        return new Vector3(xPrime, pos2.y, zPrime);
    }
    Vector3 RotateZ(float x, float y, float z)
    {
        Vector3 pos3 = new Vector3(x, y, z);
        float xPrime = (pos3.x * Mathf.Cos(angle)) - (pos3.y * Mathf.Sin(angle));
        float yPrime = (pos3.x * Mathf.Sin(angle)) - (pos3.y * Mathf.Cos(angle));

        return new Vector3(xPrime, yPrime, pos3.z);
    }
}