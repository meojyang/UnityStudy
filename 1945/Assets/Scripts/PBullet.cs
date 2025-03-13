using UnityEngine;

public class PBullet : MonoBehaviour
{

    public float Speed = 4.0f;
    public GameObject effect;
    //�Ѿ��� ���Ϳ� ������ �������� ������ �ϴϱ�
    public GameObject Item;
    
    void Update()
    {
        //�̻����� ���� �����ϰŰ�
        //�� ���� * ���ǵ� * Ÿ��

        //�̵� �Լ�: transform.Translate(���� * �ӵ� * �ð�);
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }


    //ȭ�� ������ �������
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        //�ڱ� �ڽ��� �ı�

    }

    //�÷��̾� �̻����� ���Ϳ� �浹�ϸ�
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {

            //���ڸ��� ����Ʈ ����

            //�̷��� �ᵵ �ǰ�
            //Destroy(Instantiate(effect, transform.position, Quaternion.identity), 1);
            GameObject eff = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(eff, 1);
            //�̷��� �ᵵ �ǰ�
            //�����ߴٰ� 1�ʵڿ� ����

            //�̻����� �����ϰ�
            Destroy(gameObject);
            //���͵� �����Ѵ�
            Destroy(collision.gameObject);
            //�׸��� �������� ����
            DropItem();
            
        }
    }

    private void DropItem()
    {
        GameObject newItem = Instantiate(Item, transform.position, Quaternion.identity);

        // Rigidbody2D ��������
        Rigidbody2D rig = newItem.GetComponent<Rigidbody2D>();

        if (rig != null)
        {
            // ������ ���� ����
            Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(0.5f, 1f)).normalized;
            float Force = 4f;

            rig.AddForce(randomDirection * Force, ForceMode2D.Impulse);
        }
    }
}
