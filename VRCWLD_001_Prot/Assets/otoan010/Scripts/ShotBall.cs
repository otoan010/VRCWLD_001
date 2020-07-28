using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBall : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        Throw(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Throw(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

}
