using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollision : MonoBehaviour
{
    public int currentScore = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CheckDie(collision);
        CheckScore(collision);
    }
    protected void CheckDie(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("FishEnemyLv2") && currentScore < 5)
        {           
            Debug.Log("Die");
            Destroy(gameObject);
        }
        if (collision.gameObject.tag.Equals("FishEnemyLv3") && currentScore < 15)
        {
            Debug.Log("Die");
            Destroy(gameObject);
        }
    }   
    protected void CheckScore(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("FishEnemy"))
        {
            currentScore++;
            Debug.Log("Feeding!");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag.Equals("FishEnemyLv2"))
        {
            currentScore += 2;
            Debug.Log("Feeding!");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag.Equals("FishEnemyLv3"))
        {
            currentScore += 3;
            Debug.Log("Feeding!");
            Destroy(collision.gameObject);
        }
    }

}
