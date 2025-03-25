using UnityEngine;

public class Hit_Lazer : MonoBehaviour
{
    float Speed = 50f;
    Vector2 MousePos;
    Vector3 dir;
    Transform tr;

    float angle;
    Vector3 dirNo; //노멀라이즈한 방향


    void Start()
    {
        tr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        MousePos = Input.mousePosition;
        MousePos = Camera.main.ScreenToWorldPoint(MousePos);

        Vector3 Pos = new Vector3(MousePos.x, MousePos.y, 0);
        dir = Pos - tr.position; //마우스 - 플레이어 포지션을 빼면 마우스를 바라보는 벡터

        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        dirNo = new Vector3(dir.x, dir.y, 0).normalized;

        Destroy(gameObject, 4f);
    }
    
    void Update()
    {

        //회전 적용
        transform.rotation = Quaternion.Euler(0f, 0f, angle); 

        transform.position += dirNo * Speed * Time.deltaTime;
    }
}
