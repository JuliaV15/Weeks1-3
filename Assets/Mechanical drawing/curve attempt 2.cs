using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curveattempt2 : MonoBehaviour
{
    public AnimationCurve curve;
    public Transform start;
    public Transform end;

    [Range(0, 1)]
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t > 1)
        {
            t = 0;
        }

        transform.position = Vector3.one * curve.Evaluate(t);
    }
}
