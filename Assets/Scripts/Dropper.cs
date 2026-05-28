using System;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeToWait = 3;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
