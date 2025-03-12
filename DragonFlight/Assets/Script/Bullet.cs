using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{

    public float moveSpeed;

    public GameObject explosion;
    //프리팹을 갖고오려면 게임오브젝트, 기억!
    

    void Start()
    {
        
    }
    
    void Update()
    {
        //y축으로 이동
        transform.Translate(0, moveSpeed * Time.deltaTime * 2, 0);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //2D충돌 트리거 이벤트
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 적이 부딪히면..
        if(collision.gameObject.tag == "Enemy")
        {
            if (collision.gameObject.name == "enemy1(Clone)")
            {
                //폭발 이펙트 생성하고
                Instantiate(explosion, transform.position, Quaternion.identity);
                //죽는 사운드
                SoundManager.instance.SoundDie();
                //적 지우기
                Destroy(collision.gameObject);
                Destroy(gameObject);
                GameManager.gm.AddScore(30);
            }
            else if(collision.gameObject.name == "enemy2(Clone)")
            {
                //폭발 이펙트 생성하고
                Instantiate(explosion, transform.position, Quaternion.identity);
                //죽는 사운드
                SoundManager.instance.SoundDie();
                //적 지우기
                Destroy(collision.gameObject);
                Destroy(gameObject);
                GameManager.gm.AddScore(100);
            }
            else if(collision.gameObject.name == "enemy3(Clone)")
            {
                //폭발 이펙트 생성하고
                Instantiate(explosion, transform.position, Quaternion.identity);
                //죽는 사운드
                SoundManager.instance.SoundDie();
                //적 지우기
                Destroy(collision.gameObject);
                Destroy(gameObject);
                GameManager.gm.AddScore(500);
            }
            else if(collision.gameObject.name == "boss(Clone)")
            {
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(gameObject);
                GameManager.gm.bossCount++;
                Debug.Log("현재 보스 카운트 : " + GameManager.gm.bossCount);
                if(GameManager.gm.bossCount == 20)
                {
                    SoundManager.instance.SoundDie();
                    Destroy(collision.gameObject);
                    GameManager.gm.AddScore(50000);
                }
            }
            
        }
    }
}
