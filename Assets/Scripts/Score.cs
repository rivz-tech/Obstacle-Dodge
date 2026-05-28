using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            score++;
            Debug.Log($"Score: {score}");
        }
    }
}
