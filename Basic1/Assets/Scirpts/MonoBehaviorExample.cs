using UnityEngine;

public class MonoBehaviorExample : MonoBehaviour
{   
    void Start()
    {
        Debug.Log("Start: ������ ���۵ɶ� ȣ��˴ϴ�.");
    }
    
    void Update()
    {
        Debug.Log("Update: �� �����Ӹ��� ȣ��˴ϴ�.");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate: ���� ���꿡 ���˴ϴ�.");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    //��Ʈ�� ����Ʈ m�� ������ ���� ������ ������ �Լ����� ���´� üũ�ؼ� �ᵵ ��

    //oce�� �ĵ� oncollisionenter �Լ��� ����
    //�̰͵� ������


}
