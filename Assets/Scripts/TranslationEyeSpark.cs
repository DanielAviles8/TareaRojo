using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationEyeSpark : MonoBehaviour
{
    [SerializeField] private GameObject sparkEye;
    public Vector3 delta;

    // Update is called once per frame
    void Update()
    {
        Translate();
    }

    public void Translate()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            sparkEye.transform.position = FormulaX(sparkEye.transform.position, delta);
        }
    }
    public Vector3 FormulaX(Vector3 sparkPosX, Vector3 deltaVar)
    {
        float xPrime = (sparkPosX.x * 1) + (1 * deltaVar.x);
        float yPrime = (sparkPosX.y * 1) + (1 * deltaVar.y);
        float zPrime = (sparkPosX.z * 1) + (1 * deltaVar.z);

        return new Vector3(xPrime, yPrime, zPrime);
    }
}
