using UnityEngine;

public class Stair : MonoBehaviour
{   
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.rigidbody.CompareTag("Player"))
        {
            collision.rigidbody.gravityScale = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.rigidbody.CompareTag("Player"))
        {
            collision.rigidbody.gravityScale = 1;
        }
    }
}
