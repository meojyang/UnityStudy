using UnityEngine;

public class BackGroundRepeat : MonoBehaviour
{

    //��ũ���� �ӵ��� ����� ����
    public float scrollSpeed = 1.2f;

    //������ ���͸��� �����͸� �޾ƿ� ��ü�� ����
    private Material thisMaterial;


    void Start()
    {
        //��ü�� �����ɶ� ���� 1ȸ ȣ��
        //���� ��ü�� component���� ������ renderer ��� ������Ʈ�� material������ �޾ƿ´�.

        thisMaterial = GetComponent<Renderer>().material;
    }
    
    void Update()
    {

        //���Ӱ� �������� offset ��ü�� ����
        Vector2 newOffset = thisMaterial.mainTextureOffset;
        //Y�κп� ���� y���� �ӵ��� ������ �����ؼ� ������
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));

        //���������� offset �� ������
        thisMaterial.mainTextureOffset = newOffset;
    }
}
