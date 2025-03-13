using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;     

    Animator ani; //�ִϸ����͸� ������ �Լ�

    public int powerLevel = 1;

    public GameObject bullet; //4���� �迭�� ���� ����
    public GameObject bullet2;
    public GameObject bullet3;
    public GameObject bullet4;

    public Transform pos = null; //�߻� ��ġ

    //������

    //������

    void Start()
    {        
        ani = GetComponent<Animator>();
    }
    
    void Update()
    {
        //����Ű�� ���� ������
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
            if (powerLevel == 1)           
                //������ ��ġ ���� �ְ� ����
                Instantiate(bullet, pos.position, Quaternion.identity);
            else if (powerLevel == 2)
                //������ ��ġ ���� �ְ� ����
                Instantiate(bullet2, pos.position, Quaternion.identity);
            else if (powerLevel == 3)
                //������ ��ġ ���� �ְ� ����
                Instantiate(bullet3, pos.position, Quaternion.identity);
            else if (powerLevel == 4)
                //������ ��ġ ���� �ְ� ����
                Instantiate(bullet4, pos.position, Quaternion.identity);

        }
        //�Ҹ��� �ڱ� ��ġ���� �������
        //�׷��� ���� Launcher�� ��� �ڱ� ��ġ���� ����

        transform.Translate(moveX, moveY, 0);



        //ĳ������ ���� ��ǥ�� ����Ʈ ��ǥ��� ��ȯ���ش�.
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        viewPos.x = Mathf.Clamp01(viewPos.x); //x���� 0�̻�, 1���Ϸ� �����Ѵ�.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y���� 0�̻�, 1���Ϸ� �����Ѵ�.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);//�ٽÿ�����ǥ�� ��ȯ
        transform.position = worldPos; //��ǥ�� �����Ѵ�.


    }

    public void powerLevelUp()
    {
        if (powerLevel < 4)
            powerLevel++;
    }
}
