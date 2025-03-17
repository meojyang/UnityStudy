using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;     

    Animator ani; //애니메이터를 가져올 함수
    public int powerLevel = 0;
    public GameObject[] bullet; //4개의 배열로 만들 예정
    public GameObject powerUp;
    public Transform pos = null; //발사 위치

    //아이템

    //레이저

    void Start()
    {        
        ani = GetComponent<Animator>();
    }
    
    void Update()
    {
        //방향키에 따른 움직임
        float moveX = moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float moveY = moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

        

        if (Input.GetAxis("Horizontal") <= -0.1f)        
            ani.SetBool("left", true);        
        else        
            ani.SetBool("left", false);
        

        if (Input.GetAxis("Horizontal") >= 0.1f)
            ani.SetBool("right", true);        
        else       
            ani.SetBool("right", false);

        if (Input.GetAxis("Vertical") >= 0.1f)
            ani.SetBool("up", true);
        else
            ani.SetBool("up", false);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //프리팹 위치 방향 넣고 생성
            Instantiate(bullet[powerLevel], pos.position, Quaternion.identity);            
        }
        //불릿을 자기 위치에서 만들어줌
        //그래서 굳이 Launcher가 없어도 자기 위치에서 나감

        transform.Translate(moveX, moveY, 0);



        //캐릭터의 월드 좌표를 뷰포트 좌표계로 변환해준다.
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        viewPos.x = Mathf.Clamp01(viewPos.x); //x값을 0이상, 1이하로 제한한다.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y값을 0이상, 1이하로 제한한다.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);//다시월드좌표로 변환
        transform.position = worldPos; //좌표를 적용한다.


    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            powerLevel++;

            if (powerLevel >= 3)
                powerLevel = 3;

            //부딪힌 아이템 삭제
            Destroy(collision.gameObject);

            GameObject powerUpEffect = Instantiate(powerUp, transform.position, Quaternion.identity);

            Destroy(powerUpEffect, 1f);
        }


    }
}
