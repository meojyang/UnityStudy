using UnityEngine;

public class ConditionExample : MonoBehaviour
{
    //연산자와 조건문
    public int health = 100;

    
    

    
    void Update()
    {
        health -= 1;
        Debug.Log("현재 HP : " + health);

        if (health <= 0)
            Debug.Log("Game Over!");
    }
}
