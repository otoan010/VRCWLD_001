using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBall : MonoBehaviour
{

    [SerializeField]
    private float throwX = 0;
     [SerializeField]
    private float throwY = 300;
     [SerializeField]
    private float throwZ = 1500;

    // Start is called before the first frame update
    void Start()
    {
        Throw(new Vector3(0, throwY, throwZ));
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
