using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health = 10;
    public float Attack = 3;
    public float Speed = 1.0f;

    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);
    }

    public void GetDamage(int attack)
    {
        Health -= attack;

        if (Health <= 0)
            Destroy(gameObject);
    }
}
