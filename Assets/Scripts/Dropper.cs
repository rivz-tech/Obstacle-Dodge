using System;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeToWait = 3;

    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("Dropping now!!!");
        }
    }
}
