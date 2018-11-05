using UnityEngine;

using System.Collections;

using TMPro; 




public class ScoreScript : MonoBehaviour{
    private TextMeshProUGUI score;
   
    public static int scoreValue = 0;

    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        score.text = "Score: " + scoreValue;        
    }

}

  