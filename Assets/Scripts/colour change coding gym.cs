using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourchangecodinggym : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    //public Color white;
   // public Color red;

    // Start is called before the first frame update
    void Start()
    {
     spriteRenderer.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        

        // if (Input.GetMouseButtonDown(0)) - change colour from white to red when clicked
        {

            // Color Update();
           // spriteRenderer.color = Color.red;
        }

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetButtonDown("Fire1"))
        {
            transform.position = mousePos;
            spriteRenderer.color = Random.ColorHSV();
        }


    }
}