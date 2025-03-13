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

            //�������� �÷��̾�� ������ �������� �ϴϱ�
            Destroy(gameObject);
            //�Ŀ��� ȿ�� ���
            GameObject powerUpEffect = Instantiate(powerUp, transform.position, Quaternion.identity);

            Destroy(powerUpEffect, 1f);
            p.powerLevelUp();
        }                
    }
}
