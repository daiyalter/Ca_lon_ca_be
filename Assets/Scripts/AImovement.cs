using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AImovement : MonoBehaviour
{
    public float speed;
    void Update()
    {
        gameObject.transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
    }
}