using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float ss = -2; //���͸� ������ X��
    public float es = 2; //���͸� ������ x���� ��

    public float StartTime = 1;
    public float SpawnStop = 10;
    public GameObject monster;
    public GameObject monster2;

    bool flag = true;
    bool flag2 = true;


    void Start()
    {
        StartCoroutine("RandomSpawn");
        Invoke("Stop", SpawnStop);       
        
    }
        

    //�ڷ�ƾ���� ���͸� �����ϰ� ����

    IEnumerator RandomSpawn()
    {
        while (flag)
        {

            yield return new WaitForSeconds(StartTime);
            //x�� ����
            float x = Random.Range(ss, es);

            Vector2 r = new Vector2(x, transform.position.y);
            Instantiate(monster, r, Quaternion.identity);
        }
    }


    IEnumerator RandomSpawn2()
    {
        while (flag2)
        {

            yield return new WaitForSeconds(StartTime);
            //x�� ����
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

    }

}
