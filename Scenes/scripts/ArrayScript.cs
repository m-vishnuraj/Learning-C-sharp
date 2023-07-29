using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] rollNumbers;
    string[] names = new string[4];
    void Start()
    {
        names[0] = "Vishnu";
        names[1] = "Vishn";
        names[2] = "Vish";
        names[3] = "Vis";

        print(rollNumbers[2]);
        print(rollNumbers.Length);
        print(names[0]);
        print(names[1].Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
