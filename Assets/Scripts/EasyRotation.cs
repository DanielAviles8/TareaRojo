using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyRotation : MonoBehaviour
{
    MeshFilter filter;
	[SerializeField] private Vector3 dir;
    // Start is called before the first frame update
    void Start()
	{
		Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
	    gameObject.transform.Rotate(dir);
	    
    }
}
