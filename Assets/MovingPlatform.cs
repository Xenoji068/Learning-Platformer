using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    Rigidbody2D platform;

    public bool hor, ver;
    // Start is called before the first frame update
    void Start()
    {
        platform = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hor)
        {
            if (Time.deltaTime % 5 == 0)
            {
                platform.velocity = new Vector2(5, 0);
            }
            

        }
        else if (ver)
        {
            platform.velocity = new Vector2(0,5);
        }

        
    }
}
