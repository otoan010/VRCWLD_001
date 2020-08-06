using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
    GameObject target;
    AudioSource se;
    
    
    // Start is called before the first frame update
    void Start()
    {
        target = Camera.main.gameObject;
        se = GetComponents<AudioSource>()[1];
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(target.transform.position, transform.position) < 0.5f)
        {
            se.Play();
        }
    }
}
