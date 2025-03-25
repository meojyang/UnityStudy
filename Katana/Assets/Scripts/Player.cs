using System.Collections.Generic;

using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public float jumpUp = 1;
    public float power = 3;
    public Vector3 direction;
    public GameObject slash;


    public GameObject Shadow1;
    List<GameObject> sh = new List<GameObject>();

    //히트 이펙트
    public GameObject hit_lazer;


    Animator pAnimator;
    Rigidbody2D pRig2D;
    SpriteRenderer sp;

    void Start()
    {
        pAnimator = GetComponent<Animator>();
        pRig2D = GetComponent<Rigidbody2D>();
        direction = Vector2.zero;
        sp = GetComponent<SpriteRenderer>();

    }


    void KeyInput()
    {
        direction.x = Input.GetAxisRaw("Horizontal"); //왼쪽은 -1   0   1

        if (direction.x < 0)
        {
            //left
            sp.flipX = true;
            pAnimator.SetBool("run", true);

            //ShadowFlip

            for (int i = 0; i < sh.Count; i++)
            {
                sh[i].GetComponent<SpriteRenderer>().flipX = sp.flipX;
            }
        }
        else if (direction.x > 0)
        {
            //right
            sp.flipX = false;
            pAnimator.SetBool("run", true);

            for (int i = 0; i < sh.Count; i++)
            {
                sh[i].GetComponent<SpriteRenderer>().flipX = sp.flipX;
            }
        }
        else if (direction.x == 0)
        {
            pAnimator.SetBool("run", false);

            for (int i = 0; i < sh.Count; i++)
            {
                Destroy(sh[i]);
                sh.RemoveAt(i);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            pAnimator.SetTrigger("Attack");
            Instantiate(hit_lazer, transform.position, Quaternion.identity);
        }


    }

    void Update()
    {
        KeyInput();
        Move();

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (pAnimator.GetBool("jump") == false)
            {
                Jump();
                pAnimator.SetBool("jump", true);
            }
        }
    }

    public void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        Debug.DrawRay(pRig2D.position, Vector3.down, new Color(0, 1, 0));

        RaycastHit2D rayHit = Physics2D.Raycast(pRig2D.position, Vector3.down, 1, LayerMask.GetMask("Ground"));

        if (pRig2D.linearVelocityY < 0)
        {
            if (rayHit.collider != null)
            {
                if (rayHit.distance < 0.7f)
                {
                    pAnimator.SetBool("jump", false);
                }
            }
        }
    }

    public void Jump()
    {
        pRig2D.linearVelocity = Vector2.zero;

        pRig2D.AddForce(new Vector2(0, jumpUp), ForceMode2D.Impulse);
    }

    public void AttSlash()
    {
        //플레이어 오른쪽
        if (sp.flipX == false)
        {
            //pRig2D.AddForce(Vector2.right * power, ForceMode2D.Impulse);
            //플레이어의 오른쪽에 슬래쉬
            GameObject go = Instantiate(slash, transform.position, Quaternion.identity);
            //go.GetComponent<SpriteRenderer>().flipX = sp.flipX;
            //플립은 없애줘도 됨
        }
        else
        {
            //pRig2D.AddForce(Vector2.left * power, ForceMode2D.Impulse);
            GameObject go = Instantiate(slash, transform.position, Quaternion.identity);
           // go.GetComponent<SpriteRenderer>().flipX = sp.flipX;
        }
    }

    public void RunShadow()
    {
        if (sh.Count < 6)
        {
            GameObject go = Instantiate(Shadow1, transform.position, Quaternion.identity);
            go.GetComponent<Shadow>().TwSpeed = 10 - sh.Count;
            sh.Add(go);
        }
    }

}
