using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPlayer : MonoBehaviour
{
    public int fishLevel=0;
    public Transform player;
    public FishCollision score;
    void Level()
    {
        if (score.currentScore >= 10)
        {
            Debug.Log("Fish Player Lv 3");
            fishLevel += 1;
            player.transform.localScale += new Vector3(3, 3, 0);
        }
        else if (score.currentScore >= 5)
        {
            Debug.Log("Fish Player Lv 2");
            fishLevel += 1;
            player.transform.localScale += new Vector3(2, 2, 0);
        }
        else
        {
            Debug.Log("Fish Player Lv 1");
            fishLevel += 1;         
        }
    }
}
