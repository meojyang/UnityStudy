using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float ss = -2; //몬스터를 생성할 X값
    public float es = 2; //몬스터를 생성할 x값의 끝

    public float StartTime = 1;
    public float SpawnStop = 10;
    public GameObject monster;
    public GameObject monster2;
    public GameObject boss;

    bool flag = true;
    bool flag2 = true;


    [SerializeField]
    GameObject textBossWarning;


    private void Awake()
    {
        textBossWarning.SetActive(false);

        //PoolManager.Instance.CreatePool(monster, 10);
        //몬스터 프리팹 10개를 풀에 등록
        //이제 꺼내다 쓸 수 있는 프리팹이 10개가 있는거임


    }


    void Start()
    {
        StartCoroutine("RandomSpawn");
        Invoke("Stop", SpawnStop);       
        
    }
        

    //코루틴으로 몬스터를 랜덤하게 생성

    IEnumerator RandomSpawn()
    {
        while (flag)
        {

            yield return new WaitForSeconds(StartTime);
            //x값 랜덤
            float x = Random.Range(ss, es);

            Vector2 r = new Vector2(x, transform.position.y);
            Instantiate(monster, r, Quaternion.identity);
            /*GameObject enemy = PoolManager.Instance.Get(monster);
            enemy.transform.position = r;*/
        }
    }


    IEnumerator RandomSpawn2()
    {
        while (flag2)
        {

            yield return new WaitForSeconds(StartTime);
            //x값 랜덤
            float x = Random.Range(ss, es);

            Vector2 r = new Vector2(x, transform.position.y);
            Instantiate(monster2, r, Quaternion.identity);
        }
    }

    public void Stop()
    {
        flag = false;
        StopCoroutine("RandomSpawn");

        StartCoroutine("RandomSpawn2");
        Invoke("Stop2", (SpawnStop + 2));
        
    }

    public void Stop2()
    {
        flag2 = false;        
        StartCoroutine("RandomSpawn2");
        textBossWarning.SetActive(true);
        StopCoroutine("RandomSpawn2");
        Vector3 pos = new Vector3(0, 3.9f, 0);
        //보스 생성 위치
        GameObject go = Instantiate(boss, pos, Quaternion.identity);
    }

}
