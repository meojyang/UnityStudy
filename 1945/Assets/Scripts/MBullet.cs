using UnityEngine;

public class MBullet : MonoBehaviour
{
    public float Speed = 5f;

    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //만약 몬스터불릿이 플레이어와 충돌하면?
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //미사일을 지워

            Destroy(gameObject);

        }
    }
}
