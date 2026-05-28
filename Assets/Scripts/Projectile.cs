using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float moveSpeed = 5f;

    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * moveSpeed);
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
