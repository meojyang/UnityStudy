using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //게임매니저도 싱글톤으로 만든다
    //어디서나 접근할 수 있도록
    public static GameManager gm;
    public int score = 0;
    //Text는 UnityEngine.UI를 using 해줘야한다
    //점수 표시하는 텍스트 객체
    public Text scoreText;
    public Text startText;  //게임 시작전 카운트다운 표시할 텍스트 객체
    public Text gameClearTEXT;

    public int bossCount = 0;
    public bool gameCleared = false;


    public void Awake()
    {
        if (gm == null) gm = this;
    }

    void Start()
    {        
        StartCoroutine("StartGame");
        gameClearTEXT.gameObject.SetActive(false);
    }

    private void Update()
    {
        GameClear();
    }

    void GameClear()
    {        
        if (bossCount == 20 && gameCleared == false)
        {
            gameCleared = true;
            gameClearTEXT.gameObject.SetActive(true);
            scoreText.gameObject.SetActive(false);
        }
    }

    IEnumerator StartGame()
    {
        int i = 3;

        Time.timeScale = 0; //전체 시간멈춤

        while (i > 0)
        {
            startText.text = i.ToString();

            yield return new WaitForSeconds(1f);
            i--;
            if(i == 0)
            {
                startText.gameObject.SetActive(false); //감추기
                Time.timeScale = 1; //다시 시간 정상화
            }
        }
        
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score : " + score;
    }
}
