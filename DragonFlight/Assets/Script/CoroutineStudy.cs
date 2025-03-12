using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class CoroutineStudy : MonoBehaviour
{   
    //유니티의 필살기
    //코.루.틴
    //실행을 멈췄다가 다시 이어서 실행할 수 있는 기능
    //이걸 이용하면 일정시간후 실행되거나, 특정 조건을 기다리는 등의 기능을 쉽게 구현 가능하다.


    void Start()
    {
        /*StartCoroutine("ExampleCoroutine");
        StartCoroutine(ExampleCoroutine()); //우왕 신기하다 //함수로도 되고 문자열로도 되고*/
    }
    
    /*IEnumerator ExampleCoroutine()
    {
        *//*Debug.Log("코루틴 시작");
        yield return new WaitForSeconds(2f); //2초대기
        Debug.Log("2초 후 실행");*//*

        while (true)
        {
            Debug.Log("매 1초마다 실행!");
            yield return new WaitForSeconds(2f);
        }

    }*/


    
}
