using UnityEngine;

public class PBullet : MonoBehaviour
{

    public float Speed = 4.0f;
    public GameObject effect;
    //총알이 몬스터에 닿으면 아이템을 만들어야 하니까
    public GameObject Item;
    
    void Update()
    {
        //미사일은 위로 움직일거고
        //위 방향 * 스피드 * 타임

        //이동 함수: transform.Translate(방향 * 속도 * 시간);
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }


    //화면 밖으로 나갈경우
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        //자기 자신을 파괴

    }

    //플레이어 미사일이 몬스터와 충돌하면
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {

            //그자리에 이펙트 생성

            //이렇게 써도 되고
            //Destroy(Instantiate(effect, transform.position, Quaternion.identity), 1);
            GameObject eff = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(eff, 1);
            //이렇게 써도 되고
            //생성했다가 1초뒤에 삭제

            //미사일을 삭제하고
            Destroy(gameObject);
            //몬스터도 삭제한다
            Destroy(collision.gameObject);
            //그리고 아이템을 생성
            DropItem();
            
        }
    }

    private void DropItem()
    {
        GameObject newItem = Instantiate(Item, transform.position, Quaternion.identity);

        // Rigidbody2D 가져오기
        Rigidbody2D rig = newItem.GetComponent<Rigidbody2D>();

        if (rig != null)
        {
            // 랜덤한 방향 적용
            Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(0.5f, 1f)).normalized;
            float Force = 4f;

            rig.AddForce(randomDirection * Force, ForceMode2D.Impulse);
        }
    }
}
