using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matoTargetMover : MonoBehaviour
{
    
    private Vector3 targetpos;

    [SerializeField]
    private float targetSpeed;

    // Start is called before the first frame update
    void Start()
    {
        targetpos = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * targetSpeed + targetpos.x, targetpos.y, targetpos.z);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<ParticleSystem>().Play();
    }


}
