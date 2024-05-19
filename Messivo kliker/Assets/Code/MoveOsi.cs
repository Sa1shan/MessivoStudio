using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOsi : MonoBehaviour
{
    public float rotationSpeed = 100.0f;

    private void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}