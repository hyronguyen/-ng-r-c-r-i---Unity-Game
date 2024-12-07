using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int curensprite = 0;
    public Sprite[] lifesprites;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = lifesprites[0];
        curensprite += 1;

    }

    public void lifecondition()

    {
       
        
            if (curensprite <4)
        { GetComponent<SpriteRenderer>().sprite = lifesprites[curensprite];
            curensprite += 1;
        }
           
            
    }
    
    
}
