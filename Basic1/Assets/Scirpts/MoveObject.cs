using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public float speed = 5.0f; //이돟속도 설정




    void Start()
    {
        
    }
    
    void Update()
    {

        /*Vector3 a = Vector3.left;
            //vector3.left 나 right, forward, 등등 이런 변수들은 다 크기 1짜리인 노멀벡터이다.
        //키입력 함수를 호출해준다.
        float move = Input.GetAxis("Horizontal");
        //좌우 입력에 대해 -1 또는 1쪽으로 값이 증가한다.
        //-1이나 1이 들어가면 왼쪽 또는 오른쪽 판정을 하게 된다
        //방향 * 속도 * 타임.델타타임(업데이트 속도)
        transform.Translate(Vector3.right *move *speed *Time.deltaTime);*/

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.position += move * speed * Time.deltaTime;
        //transform.Translate(move * speed * Time.deltaTime);
        //둘다 같음

    }
}
