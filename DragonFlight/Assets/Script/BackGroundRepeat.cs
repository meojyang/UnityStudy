using UnityEngine;

public class BackGroundRepeat : MonoBehaviour
{

    //스크롤할 속도를 상수로 지정
    public float scrollSpeed = 1.2f;

    //쿼드의 머터리얼 데이터를 받아올 객체를 선언
    private Material thisMaterial;


    void Start()
    {
        //객체가 생성될때 최초 1회 호출
        //현재 객체의 component들을 참조해 renderer 라는 컴포넌트의 material정보를 받아온다.

        thisMaterial = GetComponent<Renderer>().material;
    }
    
    void Update()
    {

        //새롭게 지정해줄 offset 객체를 선언
        Vector2 newOffset = thisMaterial.mainTextureOffset;
        //Y부분에 현재 y값에 속도에 프레임 보정해서 더해줌
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));

        //최종적으로 offset 값 ㅅ지정
        thisMaterial.mainTextureOffset = newOffset;
    }
}
