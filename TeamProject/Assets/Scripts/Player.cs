using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 3f;
    public float Health = 100;

    public TMP_Text infoText;    

    void Start()
    {
        UpdateText();
    }

    void Update()
    {

        

        float moveX = Speed * Time.deltaTime * Input.GetAxis("Horizontal");
        float moveY = Speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(moveX, moveY, 0);               

        //캐릭터의 월드 좌표를 뷰포트 좌표계로 변환해준다.
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        viewPos.x = Mathf.Clamp01(viewPos.x); //x값을 0이상, 1이하로 제한한다.
        viewPos.y = Mathf.Clamp01(viewPos.y); //y값을 0이상, 1이하로 제한한다.
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);//다시월드좌표로 변환
        transform.position = worldPos; //좌표를 적용한다.

        
    }

    public void GetDamage(int attack)
    {
        Health -= attack;
        UpdateText();
    }

    public void UpdateText()
    {
        if(infoText != null)
        {
            infoText.text = Health.ToString();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy") == true){
            GetDamage(collision.GetComponent<Enemy>().Attack);
        }
    }

    
}
