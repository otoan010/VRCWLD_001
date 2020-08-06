using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Time.deltaTime * speed;

        transform.position -= new Vector3(0, 0, z);

        if (transform.position.z < -30)
        {
            Init();
        }
    }

    void Init()
    {
        speed = Random.Range(20f, 60f);
        float x = Random.Range(-1f, -1f);
        float y = Random.Range(0.5f, 5f);
        float z = 50;
        transform.position = new Vector3(x, y, z);
    }
}
