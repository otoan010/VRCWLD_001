using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatoGenerator : MonoBehaviour
{
   public GameObject MatoPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject enemy = Instantiate(MatoPrefab, Vector3.zero, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
