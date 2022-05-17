using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Vector3 cubeMovement;
    public Vector3 cubeRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += cubeMovement;
        transform.eulerAngles += cubeRotation;
    }
}
