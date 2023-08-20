using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject fishPrefab;
    public GameObject gameArea;

    public int fishCount = 0;
    public int fishLimit = 50;
    public int fishesPerFrame = 1;

    public float spawnCircleRadius = 150.0f;
    public float deathCircleRadius = 160.0f;

    public float fastestSpeed = 20.0f;
    public float slowestSpeed = 1.0f;

    void Update()
    {
        MaintainPopulation();
    }
    
    void MaintainPopulation()
    {
        if (fishCount < fishLimit)
        {
            for (int i=0; i < fishesPerFrame; i ++)
            {
                Vector3 position = GetRandomPosition();
                FishEnemy newFish = AddFish(position);
            }
        }
    }
    Vector3 GetRandomPosition()
    {
        Vector3 position = Random.insideUnitCircle.normalized;

        position *= spawnCircleRadius;
        position += gameArea.transform.position;

        return position;
    }
    FishEnemy AddFish(Vector3 position)
    {
        fishCount += 1;
        GameObject newFish = Instantiate(
            fishPrefab,
            position,
            Quaternion.FromToRotation(Vector3.up, (gameArea.transform.position - position)),
            gameObject.transform);

        FishEnemy fishScript = newFish.GetComponent<FishEnemy>();
        fishScript.fishSpawner = this;
        fishScript.gameArea = gameArea;
        fishScript.speed = Random.Range(slowestSpeed, fastestSpeed);

        return fishScript;
    }
}