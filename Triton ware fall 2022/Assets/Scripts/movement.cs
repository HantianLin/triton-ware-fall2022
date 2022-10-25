using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float playerSpeed = 1.0f;

    private float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hello");
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x < 5.0f)
        {
            transform.position = new Vector3(transform.position.x + playerSpeed, transform.position.y, transform.position.z);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x > -4.15f)
        {
            transform.position = new Vector3(transform.position.x - playerSpeed, transform.position.y, transform.position.z);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey(KeyCode.W) && transform.position.y < 1.2f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + playerSpeed, transform.position.z);
        }

        if (Input.GetKey(KeyCode.S) && transform.position.y > -3.98f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - playerSpeed, transform.position.z);
        }
    }
}
