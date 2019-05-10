using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b8_sprite : MonoBehaviour
{
    private Vector2 targetPos;
    public float Ycoo;

    private void Current()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Ycoo);

            transform.position = targetPos;
        }

        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Ycoo);

            transform.position = targetPos;
        }
    }

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
