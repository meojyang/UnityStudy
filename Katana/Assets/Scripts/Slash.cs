using UnityEngine;

public class Slash : MonoBehaviour
{
    private GameObject p;
    Vector2 MousePos;
    Vector3 dir;

    float angle;
    Vector3 dirNo;







    public Vector3 direction = Vector3.right;

    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player");

        Transform tr = p.GetComponent<Transform>();
        //이동값을 갖고와
        MousePos = Input.mousePosition; //마우스 포지션도 갖고와
        MousePos = Camera.main.ScreenToWorldPoint(MousePos);
        Vector3 Pos = new Vector3(MousePos.x, MousePos.y, 0);
        dir = Pos - tr.position;

        //바라보는 각도 구하기
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //아크탄젠트2가 더 계산이 정확하다고 함



    }
    
    void Update()
    {
        //회전 적용
        transform.rotation = Quaternion.Euler(0f, 0f, angle);


        //검기의 포지션은 플레이어의 포지션
        transform.position = p.transform.position;
    }

    public void Des()
    {
        Destroy(gameObject);
    }
}
