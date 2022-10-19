using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostBrain : MonoBehaviour
{
    public float ghostSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x > -4.5f) transform.position = new Vector3(transform.position.x - ghostSpeed, transform.position.y, transform.position.z);
        else Destroy(gameObject);
    }
}
