using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer _renderer;
    Rigidbody _rigidbody;

    [SerializeField] float timeToWait = 3f;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _renderer.enabled = false;

        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait && !_renderer.enabled && !_rigidbody.useGravity) {
            Debug.Log("3 seconds has elapsed");
            _renderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
}
