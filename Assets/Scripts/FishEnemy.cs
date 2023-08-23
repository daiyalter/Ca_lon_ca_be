using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishEnemy : MonoBehaviour
{
    /*
    public FishSpawner fishSpawner;
    public GameObject gameArea;

    public float speed;

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position += transform.up * (Time.deltaTime * speed);

        float distance = Vector3.Distance(transform.position, gameArea.transform.position);
        if (distance > fishSpawner.deathCircleRadius)
        {
            RemoveFish();
        }
    }

    void RemoveFish()
    {
        Destroy(gameObject);
        fishSpawner.fishCount -= 1;
    }

    /*
    [SerializeField]
    float speed;
    [SerializeField]
    float range;
    [SerializeField]
    float maxDistance;

    Vector2 wayPoint;
    void Start()
    {
        SetNewDestination();
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint) < range)
        {
            SetNewDestination();
        }
    }
    void SetNewDestination()
    {
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }
    */
}
