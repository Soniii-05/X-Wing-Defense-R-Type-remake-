using UnityEngine;

public class Floor : MonoBehaviour
{
    Vector2 startPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= -9.13f)
        {
            transform.position = new Vector2(transform.position.x - 3f * Time.deltaTime, transform.position.y);
        } else 
          {
            transform.position = startPos;
          }
        
    }
}
