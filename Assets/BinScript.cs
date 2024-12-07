using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinScript : MonoBehaviour
{
    AudioSource bin_audio;
    LogicScript binlogic;
    void Start()
    {
        bin_audio=GetComponent<AudioSource>();
        binlogic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        bin_audio.Play();
        binlogic.AddPoint();
    }
}
