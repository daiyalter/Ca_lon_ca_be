using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollision : MonoBehaviour
{
    public int currentScore = 0;
    public FishPlayer level;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AddScore(collision);
    }
    protected void AddScore(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("FishEnemy"))
        {
            currentScore++;
            Debug.Log(currentScore);
            Destroy(gameObject);
            CheckScore();
        }
    }
    
    void CheckScore()
    {
        if (currentScore >= 10)
        {          
            Debug.Log("Fish Player Lv 3");
        }
        else if (currentScore >= 5) 
        {
            Debug.Log("Fish Player Lv 2");
            
        }
        else
        {
            Debug.Log("Fish Player Lv 1");
        }
    }

}
