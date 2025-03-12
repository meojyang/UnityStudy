using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager instance; //자기자신을 변수로 담기
    public AudioClip soundBullet; //총알 발사 사운드
    public AudioClip soundDie; //죽는 사운드
    AudioSource myAudio; //오디오소스 컴포넌트를 변수로 담는다.

    private void Awake()
    {
        if (SoundManager.instance == null) SoundManager.instance = this;
        //인스턴스가 없으면 자기자신을 담는다.
    }

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }
    
    public void SoundBullet()
    {
        //총알 발사 소리를 한번 재생하는 함수
        myAudio.PlayOneShot(soundBullet);
    }

    public void SoundDie()
    {
        //죽는소리를 한번 재생하는 함수
        myAudio.PlayOneShot(soundDie);
    }


    void Update()
    {
        
    }
}
