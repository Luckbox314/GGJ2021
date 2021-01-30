using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_movement_menu : MonoBehaviour
{

    public float speed;
	public Vector2 direction;
    private int x;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = direction.normalized * speed * Time.deltaTime;

        transform.Translate(movement);
        if(transform.position.x > 3 || transform.position.x < -3){
            speed = -speed;
        }

		
        
    }
}
