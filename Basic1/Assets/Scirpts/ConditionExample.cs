using UnityEngine;

public class ConditionExample : MonoBehaviour
{
    //�����ڿ� ���ǹ�
    public int health = 100;

    
    

    
    void Update()
    {
        health -= 1;
        Debug.Log("���� HP : " + health);

        if (health <= 0)
            Debug.Log("Game Over!");
    }
}
