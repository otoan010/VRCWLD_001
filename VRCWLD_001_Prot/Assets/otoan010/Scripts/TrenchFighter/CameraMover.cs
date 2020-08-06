using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime * 1.5f;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            if(transform.position.x > -1)
            {
                transform.position -= new Vector3(delta, 0f, 0f); 
            }
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            if(transform.position.x < 1)
            {
                transform.position += new Vector3(delta, 0f, 0f);
            }
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            if(transform.position.y > 0.5f)
            {
                transform.position -= new Vector3(0f, delta, 0f);
            }
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < 5)
            {
                transform.position += new Vector3(0f, delta, 0f);
            }
        }
    }
}
