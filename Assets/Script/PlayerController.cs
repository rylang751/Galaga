using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //~* === Use the comments in the code to complete this game === ~*//

    // === Create a float variable for the speed of the player === //
    float speed=3.0f;

    // === Create a Rigidbody2D variable for the player === //
    Rigidbody2D rigidbody2d;

    // === Create a float variable for the player's Left and Right input === //
    float horizontal;

    // === Create a public GameObject variable for the projectile prefab === //
    public GameObject projectilePrefab;
    
    
    
    void Start()
    {
        // === Write the code below to set your Rigidbody2D variable EQUAL to the Rigidbody2D component === //
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // === Write the code below to set your input variable EQUAL to the player's horizontal inputs (HINT: use ' Input.GetAxis() ') === //
        float horizontal = Input.GetAxis ("Horizontal");
    
        Vector2  position = transform.position ;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime * speed;
        transform.position = position ;  

        if(Input.GetKeyDown(KeyCode.C))
        {
            Launch();
        }


    }
       

    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);

        Projectile projectile = projectileObject.GetComponent<Projectile>();

        projectile.Launch(new Vector2(0, 1), 500);


    }
    
}
