using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReset : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        ScoreScript.scoreValue = 0;
        Destroy(gameObject);
    }

}


//made to reset score at the inprogress level after game completion 