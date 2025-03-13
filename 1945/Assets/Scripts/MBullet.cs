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

    //���� ���ͺҸ��� �÷��̾�� �浹�ϸ�?
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //�̻����� ����

            Destroy(gameObject);

        }
    }
}
