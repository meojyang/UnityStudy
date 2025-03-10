using UnityEngine;


public class Player
{
    public string Name;
    public int health;

    public Player(string playerName, int playerHealth)
    {
        Name = playerName;
        health = playerHealth;
    }

    public void ShowInfo()
    {
        Debug.Log("Name : " + Name);
        Debug.Log("Health : " + health);
    }
}


public class ClassExample : MonoBehaviour
{   
    void Start()
    {
        Player p1 = new Player("Hero", 100);
        p1.ShowInfo();
    }
    
    void Update()
    {
        
    }
}
