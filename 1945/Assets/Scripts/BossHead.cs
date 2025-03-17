using UnityEngine;

public class BossHead : MonoBehaviour
{
    [SerializeField]//직렬화
    GameObject bossbullet; //private를 안써도 클래스는 기본이 private이다

    //애니메이션에서 함수를 사용하는 방법

    public void RightDownLaunch()
    {
        GameObject go = Instantiate(bossbullet, transform.position, Quaternion.identity);

        go.GetComponent<BossMissile>().Move(new Vector2(1, -1));
    }

    public void LeftDownLaunch()
    {
        GameObject go = Instantiate(bossbullet, transform.position, Quaternion.identity);

        go.GetComponent<BossMissile>().Move(new Vector2(-1, -1));
    }

    public void DownLaunch()
    {
        GameObject go = Instantiate(bossbullet, transform.position, Quaternion.identity);

        go.GetComponent<BossMissile>().Move(new Vector2(0, -1));
    }




}
