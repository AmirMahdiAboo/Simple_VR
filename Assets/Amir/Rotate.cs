using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class Rotate : MonoBehaviour
{

    [SerializeField] private float _rotateSpeed;
    private Transform _transform;

    void Awake()
    {
        _transform = gameObject.transform;
    }


    void Update()
    {
        RotateObject();
    }

    private void RotateObject()
    {
        _transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
    }
}
