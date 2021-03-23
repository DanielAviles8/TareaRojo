using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    public Vector3 delta;
    public void Update()
    {
        Move();
    }
    public void Move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cube.transform.position = MoveMatrix(cube.transform.position, delta);
        }
    }
    public Vector3 MoveMatrix(Vector3 cubePos, Vector3 deltaVar)
    {
        float x = (cubePos.x * 1) + (cubePos.y * 0) + (cubePos.z * 0) + (1 * deltaVar.x);
        float y = (cubePos.x * 0) + (cubePos.y * 1) + (cubePos.z * 0) + (1 * deltaVar.y);
        float z = (cubePos.x * 0) + (cubePos.y * 0) + (cubePos.z * 1) + (1 * deltaVar.z);

        return new Vector3(x, y, z);
    }
}