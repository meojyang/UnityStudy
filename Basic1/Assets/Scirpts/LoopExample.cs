using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    
    void Start()
    {
        //for¹®

        /*for(int i = 1; i <= 10; i++)
        {
            Debug.Log("Count: " + i);
        }*/

        int count = 0;
        while(count < 5)
        {
            Debug.Log("Count : " + (count + 1));
            count++;
        }


    }

    
    
}
