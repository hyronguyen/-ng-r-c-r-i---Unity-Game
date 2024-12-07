using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class spwaner_script : MonoBehaviour
{
    AudioSource spa;
    //audio
    public float speed = 0.1f;
    public Transform PointA;
    public Transform PointB;
    private Vector3 origin;
    private bool backToOrigin;
    private bool GoForIt = true;
    public float BeginTime = 0;
    public int NumberOfCounts = 1000;
    private float Counter = 0;
    //move
    public float spawnrate_speed;
    public float spawnrate;
    float timer = 0;
    public GameObject[] rubbishes;
    int random;
    // Start is called before the first frame update
    void Start()
    {
       
        transform.position = PointA.transform.position;
        origin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        SMove();
      SpawnRub();
    }

    public void SpawnRub()
    {
        
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            GameObject temp = rubbishes[random];
            Instantiate(temp, new Vector3(transform.position.x, transform.position.y, temp.transform.position.z), Quaternion.identity);
            spa.Play();
            timer = 0;
        }
    }

    public void SMove()
    {
        if (GoForIt == true && Counter < NumberOfCounts)
        {
            transform.position = Vector3.MoveTowards(transform.position, backToOrigin ? origin : PointB.transform.position, speed * Time.deltaTime);

            if (transform.position == PointB.transform.position || transform.position == origin)
            {
                backToOrigin = !backToOrigin;
                Counter += 0.5f;
            }
        }

        if (Counter >= NumberOfCounts)
        {
            GoForIt = false;
        }
    }
   
}
