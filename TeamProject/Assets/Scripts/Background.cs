using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    Material material;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }
    
    void Update()
    {
        float newOffsetX = material.mainTextureOffset.x + scrollSpeed * Time.deltaTime;

        Vector2 newOffset = new Vector2(newOffsetX, 0);

        material.mainTextureOffset = newOffset;
    }
}
