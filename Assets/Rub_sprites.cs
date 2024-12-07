using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rub_sprites : MonoBehaviour
{
    private int rand;
    public Sprite[] sprites;     // Start is called before the first frame update
    void Start()
    {
        rand = Random.RandomRange(0, sprites.Length);
        GetComponent<SpriteRenderer>().sprite = sprites[rand];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
