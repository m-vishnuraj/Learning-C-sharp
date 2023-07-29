using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour

{
    // public float speed;

    public string test;

    // Start is called before the first frame update
    void Start()
    {
        if (test == "vishnu")
        {
            print("Value is correct");
        }
        else
        {
            print("Incorrect");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
}
