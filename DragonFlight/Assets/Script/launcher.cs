using UnityEngine;

public class launcher : MonoBehaviour
{
    public GameObject bullet; //미사일 프리팹 가져올 변수


    void Start()
    {
        //InvokeRepeating(함수이름, 초기지연시간, 지연할 시간)
        InvokeRepeating("Shoot", 0.3f, 0.3f);
        //일정시간동안반복시켜주는
    }

    void Shoot()
    {
        //미사일 프리팹, 런쳐포지션, 방향값 안줌
        Instantiate(bullet, transform.position, Quaternion.identity);

        SoundManager.instance.SoundBullet();
    }
    
    void Update()
    {
        
    }
}
