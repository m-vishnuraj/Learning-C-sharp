
using UnityEngine;

public class BoolScript : MonoBehaviour
{
   public bool playing;
    void Start()
    {
        if(playing) 
        {
            print("Rinning");
        }
        else if(!playing)
        {
            print("Not Playing");
        }
        else
        {
            print("End");
        }
    }

  
    void Update()
    {
        
    }
}
