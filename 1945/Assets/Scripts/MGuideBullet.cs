using UnityEngine;

public class MGuideBullet : MonoBehaviour
{
    public GameObject target;
    public float Speed = 3f;

    Vector2 dir;
    Vector2 dirNo;

    void Start()
    {
        //플레이어를 태그로 찾기
        target = GameObject.FindGameObjectWithTag("Player");
        //플레이어벡터에서 미사일의 벡터를 빼면
        //플레이어를 바라보는 벡터가 된다     
        dir = target.transform.position - transform.position;
        //dir를 노멀벡터로 만들어준다
        //방향만 구해다 쓸거니까
        dirNo = dir.normalized;
           
    }
    
    void Update()
    {
        
        transform.Translate(dirNo * Speed * Time.deltaTime);
        /*transform.position = Vector3.MoveTowards(transform.position,
            target.transform.position, Speed*Time.deltaTime);*/
        //추적 함수
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
