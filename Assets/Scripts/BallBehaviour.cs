
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class BallBehaviour : MonoBehaviour
{
    //[SerializeField]
    public Rigidbody2D _rigidbody2D;

    public Transform player;

    [HideInInspector] public bool gameStated = false;
    
    float positionDiferent;


    // Start is called before the first frame update
    void Start()
    {
      positionDiferent = player.position.x - transform.position.x;
    }
    private void FixedUpdate()
    {
        if (!gameStated)
        {
            

            transform.position = new Vector3(player.position.x - positionDiferent, player.position.y, player.position.z);

            if (Input.GetMouseButtonDown(0))
            {
                _rigidbody2D.velocity = new Vector2(8, 8);
                gameStated = true;

            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
