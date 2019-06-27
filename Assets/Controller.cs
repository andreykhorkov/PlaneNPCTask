using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    [SerializeField] private Transform plane;
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 1;
    [SerializeField] private float rotationSpeed = 30;

    void Update()
    {
        var dir = (target.position - plane.position).normalized;
        var dotProd = Vector3.Dot(plane.right, dir);
        //plane.Rotate(Vector3.up, dotProd * rotationSpeed * Time.deltaTime);
        plane.rotation *= Quaternion.AngleAxis(dotProd * rotationSpeed * Time.deltaTime, plane.up);

        plane.position += plane.forward * speed * (1 - dotProd) * Time.deltaTime;
    }
}
