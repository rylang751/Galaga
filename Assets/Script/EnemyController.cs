using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//

    public float speed = 0;
    public float timer = 3;
    public int direction = 1;
    float changeTime;
    float xRange = 12.0f;
    // Start is called before the first frame uptdate 
    void Start()
    {
        changeTime= timer;
    }
    // Uptdate is called once per frame
    void Update()
    {
        changeTime -= Time.deltaTime;
        Vector2 position = transform.position;
        if (changeTime < 0 || transform.position.x > xRange || transform.position.x < -xRange) {
            direction = -direction;
            changeTime = timer;
        }
        position.x = position.x + Time.deltaTime * speed * direction;
        transform.position = position; 

    }
    
}