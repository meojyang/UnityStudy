using UnityEngine;

public class MonoBehaviorExample : MonoBehaviour
{   
    void Start()
    {
        Debug.Log("Start: 게임이 시작될때 호출됩니다.");
    }
    
    void Update()
    {
        Debug.Log("Update: 매 프레임마다 호출됩니다.");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate: 물리 연산에 사용됩니다.");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    //컨트롤 쉬프트 m을 누르면 구현 가능한 기존의 함수들이 나온다 체크해서 써도 됨

    //oce만 쳐도 oncollisionenter 함수가 나옴
    //이것도 스니펫


}
