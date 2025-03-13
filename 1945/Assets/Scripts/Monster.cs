using UnityEngine;

public class Monster : MonoBehaviour
{

    public float moveSpeed = 3f;
    public float Delay = 1f;
    public Transform ms1;
    public Transform ms2;
    public GameObject bullet;
    


    void Start()
    {
        Invoke("CreateBullet", Delay);
    }

    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        //아래방향으로 움직여랏
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
