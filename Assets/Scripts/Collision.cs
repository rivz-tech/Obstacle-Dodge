using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        // Debug.Log("Bumped with: " + collision.gameObject.name);
    }
}
