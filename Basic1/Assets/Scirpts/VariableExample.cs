using UnityEngine;



public class VariableExample : MonoBehaviour
{

    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;



   //시작시 한번만 실행되는
    void Start()
    {
        Debug.Log("Player Name : " + playerName);
        Debug.Log("Player Score: " + playerScore);
        Debug.Log("Player Speed: " + speed);
        Debug.Log("GameOver? : " + isGameOver);
    }

    // 반복해서 실행되는 스크립트
    void Update()
    {
        
    }
}
