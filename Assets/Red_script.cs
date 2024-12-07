using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_script : MonoBehaviour
{
    LogicScript rublogic;
    // Start is called before the first frame update
    void Start()
    {
        rublogic=GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
  
}
