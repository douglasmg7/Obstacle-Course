using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotX = 0;
    [SerializeField] float rotY = 0.1f;
    [SerializeField] float rotZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotX, rotY, rotZ);
    }
}
