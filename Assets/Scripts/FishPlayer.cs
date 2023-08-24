using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPlayer : MonoBehaviour
{
    public int fishLevel=0;
    public Transform player;
    public FishCollision score;
    void Update()
    {
        if (score.currentScore >= 10)
        {
            Debug.Log("Fish Player Lv 3");
            if (player.transform.localScale.x != 3) player.transform.localScale += new Vector3(1,1,0);           
        }
        else if (score.currentScore >= 5)
        {
            Debug.Log("Fish Player Lv 2");
            if (player.transform.localScale.x != 2) player.transform.localScale *= 2;
        }
        else
        {
            Debug.Log("Fish Player Lv 1");        
        }
    }
}
