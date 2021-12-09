using DefaultNamespace;
using Unity.VisualScripting;
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

    public SceneChange _sceneChange;


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
        collision.GetComponent<BallBehaviour>().gameStated = false;
        CheckScore();
    }
    
    void UpdateScoreLabel(Text label , int score)
    {
        label.text = score.ToString();
    }

    void CheckScore()
    {
        if (scorePlayerQuantity >= 3) {
            _sceneChange.SceneChangerTo("Win");

        }else if (scoreEnemyQuantity >= 3)
        {
            _sceneChange.SceneChangerTo("Lose");
        }

    }
}
