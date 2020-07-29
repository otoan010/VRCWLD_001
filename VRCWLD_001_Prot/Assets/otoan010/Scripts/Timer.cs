using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    
    public Text timeText;
    public Text CountDownText;
    float totalTime = 60f;
    int retime;
    float countdown = 3f;
    int count;

    
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        /*
        totalTime -= Time.deltaTime;
        retime = (int)totalTime;
        timeText.text = retime.ToString();
        */

        if (countdown >= 0)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
            CountDownText.text = count.ToString();
        }
        else if (countdown <= 0)
        {
            CountDownText.text = "";
            totalTime -= Time.deltaTime;
            retime = (int)totalTime;
            timeText.text = retime.ToString();
        
            if (retime == 0)
           {
               SceneManager.LoadScene("Result");
           }

        }
    }
}
