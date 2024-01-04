using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncRotator : MonoBehaviour
{
    public Vector3 eularDirection = Vector3.up;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(eularDirection * speed* Time.deltaTime); 
    }
}
