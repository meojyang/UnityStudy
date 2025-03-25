using UnityEngine;

public class Shadow : MonoBehaviour
{
    private GameObject player;

    public float TwSpeed = 10;


    void Start()
    {
        
    }
    
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        //Lerp란 위치가 가까워질수록 천천히 가는 함수다.
        //두개의 벡터 사이클을 보간하는
        //부드러운 이동에 많이 사용하는 함수
        transform.position = Vector3.Lerp(transform.position, player.transform.position, TwSpeed * Time.deltaTime);
    }
}
