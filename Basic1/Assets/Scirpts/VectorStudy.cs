using UnityEditor.Embree;
using UnityEngine;

public class VectorStudy : MonoBehaviour
{
    /*public Vector2 v2 = new Vector2(10, 10);
    public Vector3 v3 = new Vector3(1, 1, 1);*/

    void Start()
    {
        /*Vector3 a = new Vector3(1, 0, 0);
        Vector3 b = new Vector3(2, 0, 0);

        Vector3 c = a + b;

        Debug.Log("Vector C" + c);*/

        /*Vector3 a = new Vector3(1, 1, 0);
        Vector3 b = new Vector3(2, 0, 0);

        Vector3 c = a + b;

        Debug.Log("Vector C" + c);
        Debug.Log("길이 : " + c.magnitude);*/

        //normalize
        //벡터의 크기를 1로 만들고 방향만 유지, 노멀벡터로 만든다는 뜻

        Vector3 a = new Vector3(3, 0, 0);

        Vector3 normalizedVector = a.normalized;

        Debug.Log("노멀벡터 : " + normalizedVector);

    }
    
    void Update()
    {
        
    }
}
