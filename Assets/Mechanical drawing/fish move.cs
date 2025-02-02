using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishmove : MonoBehaviour
{
    // ***** code taken from in class lerp lesson ***** //
    [Range(0, 1)]
    public float t;

    public AnimationCurve curve;
    public Transform start;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.one * Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
