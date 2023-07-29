using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour

{
    // public float speed;
    public int number;
    public string name2;

    // Start is called before the first frame update
    void Start()
    {
        int returnNumber = GiveDouble();
        print(returnNumber);
        print(GiveDoubleWithParams(15));
        print(PrintMyName("vishnu"));
        PrintName("Ram");
        PrintName1(name2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GiveDouble()
    {
        return (number * 2);
    }

    int GiveDoubleWithParams(int val)
    {
        return (val * 2);
    }

    string PrintMyName (string name)
    {
        return "My Name is "+name;
    }

    void PrintName (string name1)
    {
        print("My Name is "+name1);
    }

    void PrintName1(string name2)
    {
        print("My Name is " + name2);
    }
    void TestFunction()
    {
        print("Shoot");
        print("Destroy");
        print("Move");
       // transform.Translate(speed, 0, 0);
    }
  
}
