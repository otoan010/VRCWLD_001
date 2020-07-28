using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    
    /*
    [SerializeField]
    private float throwX = 0;
     [SerializeField]
    private float throwY = 300;
     [SerializeField]
    private float throwZ = 1500;
    */

    public GameObject ballPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         if(Input.GetMouseButtonDown(0))
         {
             GameObject ball = Instantiate(ballPrefab) as GameObject;
             Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
             Vector3 world = r.direction;
             ball.GetComponent<ShotBall>().Throw(world.normalized * 1500);
         }    
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
