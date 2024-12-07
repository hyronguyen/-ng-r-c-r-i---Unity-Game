using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadzone : MonoBehaviour
{
    Animator Shakecamera;
    AudioSource deadzona;
    LogicScript deadzonelogic;
    // Start is called before the first frame update
    void Start()
    {
        Shakecamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        deadzona= GetComponent<AudioSource>();
        deadzonelogic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Shakecamera.SetTrigger("shake");
        deadzona.Play();
        deadzonelogic.SubLife();
        
    }
}
