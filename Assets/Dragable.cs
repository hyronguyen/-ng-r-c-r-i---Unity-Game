using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragable : MonoBehaviour
{
    Vector2 Mousevec= Vector2.zero;
    private void OnMouseDown()
    {
        Mousevec= (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)(transform.position);
    }

    // Update is called once per frame
    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition)- Mousevec;
    }
}
