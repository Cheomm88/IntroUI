using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField]
    Vector3 fuerza;

    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    public void AddForces()
    {
        body.AddForce(fuerza, ForceMode.Impulse);
    }

    public void AddForces(Vector3 parametro)
    {
        body.AddForce(parametro, ForceMode.Impulse);
    }
}
