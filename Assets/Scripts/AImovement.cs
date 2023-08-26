using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AImovement : MonoBehaviour
{
    protected float speed;
    void Start()
    {
        speed = Random.Range(3, 6);
    }
    void Update()
    {
        gameObject.transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
    }
}