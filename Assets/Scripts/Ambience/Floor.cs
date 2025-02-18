using UnityEngine;

public class Floor : MonoBehaviour
{
    Vector2 startPos;
    public float speedFloor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= -9.13f) //se arriva alla posizione -9,13
        {
            transform.position = new Vector2(transform.position.x - speedFloor * Time.deltaTime, transform.position.y);
        } else 
        {
        transform.position = startPos; //va nella posizione originale
        }
        
    }
}
