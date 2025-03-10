using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{

    public Rigidbody rb;

    public float jumpForce = 5.0f; //점프 뛰는 힘


    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //RigidBody: 물리효과를 추가해 중력을 준다
            //AddForce: 점프를 뛸 힘을 오브젝트에 준다.
            //ForceMode.Impulse : 순간적으로 힘을 가한다.
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
