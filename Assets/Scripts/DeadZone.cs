using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeadZone : MonoBehaviour
{
    //attr 
    [SerializeField]
    private Text scorePlayerText;

    [SerializeField] private Text scoreEnemyText;

    private int scorePlayerQuantity;
    private int scoreEnemyQuantity;


   void OnTriggerEnter2D(Collider2D collision)
    {
        
        // ear player 
        if (gameObject.tag == "DeadZoneRight")
        {
            scorePlayerQuantity = scorePlayerQuantity + 1;

            UpdateScoreLabel(scorePlayerText,scorePlayerQuantity);

        }else if (gameObject.tag == "DeadZoneLeft")
        {

            scoreEnemyQuantity++;
            UpdateScoreLabel(scoreEnemyText,scoreEnemyQuantity);
        }

    }
    
    void UpdateScoreLabel(Text label , int score)
    {
        label.text = score.ToString();
    }
}
