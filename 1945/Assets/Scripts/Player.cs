using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;     

    Animator ani; //애니메이터를 가져올 함수


    void Start()
    {        
        ani = GetComponent<Animator>();
    }
    
    void Update()
    {
        //방향키에 따른 움직임
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

        

        transform.Translate(moveX, moveY, 0);

        
    }
}
