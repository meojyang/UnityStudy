using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //몬스터 가지고오기
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject boss;

    public bool isBossSpawned = false;
    

    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f);
        
        //적이 나타날 x좌표를 랜덤으로 설정
        if(GameManager.gm.score < 300)
            Instantiate(enemy, new Vector3(randomX, transform.position.y), Quaternion.identity);
        else if(GameManager.gm.score < 700)
            Instantiate(enemy2, new Vector3(randomX, transform.position.y), Quaternion.identity);
        else if(GameManager.gm.score <3000)
            Instantiate(enemy3, new Vector3(randomX, transform.position.y), Quaternion.identity);


        //적을 새로운 Vector3(randomX, 기존 gameObject의 y포지션quaternion의 자신 위치)

    }

    
    void Start()
    {
        //SpawnEnemy
        InvokeRepeating("SpawnEnemy", 1, 0.5f);               
    }

    public void SpawnBoss()
    {
        float BossX = 0;
                
        Instantiate(boss, new Vector3(BossX, transform.position.y), Quaternion.identity);
              
    }

    void Update()
    {
        

        if(GameManager.gm.score >= 3000 && isBossSpawned == false)
        {
            isBossSpawned = true;
            SpawnBoss();
        }        
    }
}
