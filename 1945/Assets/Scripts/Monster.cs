using UnityEngine;
using UnityEngine.UIElements;

public class Monster : MonoBehaviour
{
    public int Hp = 100;
    public float moveSpeed = 3f;
    public float Delay = 1f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;
    public GameObject Item = null;
    
    
    void Start()
    {
        Invoke("CreateBullet", Delay);
    }

    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        //아래방향으로 움직여랏
    }

    public void Damage(int attack)
    {
        Hp -= attack;
       
        if(Hp <= 0)
        {
            
            DropItem();
            Destroy(gameObject);
            
        }
    }

    public void DropItem()
    {
        Instantiate(Item, transform.position, Quaternion.identity);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);                
    }

    public void CreateBullet()
    {
        Instantiate(bullet, ms1.position, Quaternion.identity);
        Instantiate(bullet, ms2.position, Quaternion.identity);

        Invoke("CreateBullet", Delay);
    }
    
}
