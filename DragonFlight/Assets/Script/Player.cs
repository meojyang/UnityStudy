using UnityEngine;

public class Player : MonoBehaviour
{
    //�����̴� �ӵ��� ����
    public float moveSpeed = 5.0f;


    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        moveControl();
    }

    void moveControl()
    {
        //������ Axis�� ���� Ű�� ������ �Ǵ��ϰ� �ӵ��� ������ ������ ���� �̵��Ÿ��� ���Ѵ�.
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(distanceX, 0, 0);
    }
}
