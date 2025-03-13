using UnityEngine;

public class Item : MonoBehaviour
{
    public float ItemVelocity = 20f;

    Rigidbody2D rig = null;

    public GameObject powerUp;
        
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector3(ItemVelocity, ItemVelocity, 0f));
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player p = collision.GetComponent<Player>();

            //아이템이 플레이어와 닿으면 없어져야 하니까
            Destroy(gameObject);
            //파워업 효과 출력
            GameObject powerUpEffect = Instantiate(powerUp, transform.position, Quaternion.identity);

            Destroy(powerUpEffect, 1f);
            p.powerLevelUp();
        }                
    }
}
