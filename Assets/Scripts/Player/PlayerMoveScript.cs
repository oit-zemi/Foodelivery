using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    private Rigidbody2D rbody2D;

    public Vector3 jumpForce = new Vector3(0.0f, 12000f, 0.0f);

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
            rbody2D.velocity = Vector3.zero;
            this.rbody2D.AddForce(jumpForce);
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
