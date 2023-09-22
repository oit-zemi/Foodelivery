using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    private Rigidbody2D rbody2D;

    private Vector3 jumpForce1 = new Vector3(0.0f, 15000.0f, 0.0f);
    private Vector3 jumpForce2 = new Vector3(0.0f, 20000.0f, 0.0f);

    private int jumpCount = 0;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && this.jumpCount < 2)
        {
            jumpCount++;
            if (jumpCount == 2) this.rbody2D.AddForce(jumpForce2);
            else this.rbody2D.AddForce(jumpForce1);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("floor"))
        {
            jumpCount = 0;
        }
    }
}
