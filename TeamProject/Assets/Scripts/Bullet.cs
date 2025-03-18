using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float Speed = 4.0f;
    public int Attack = 10;
    public float StartDelay = 0.3f;
    public float Delay = 0.3f;


    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }       

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Enemy>().GetDamage(Attack);
        }
    }
}
