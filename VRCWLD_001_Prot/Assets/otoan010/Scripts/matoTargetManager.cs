using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class matoTargetManager : MonoBehaviour
{
    
    private Vector3 targetpos;
    public Text scoreText;
    public static int score = 0;

    [SerializeField]
    private float targetSpeed;

    public static int getscore()
    {
        return score;
    }
  
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        targetpos = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * targetSpeed + targetpos.x, targetpos.y, targetpos.z);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        score += 10;
        scoreText.text = string.Format("Score : {0}", score); 
        
        GetComponent<ParticleSystem>().Play();
    }


}
