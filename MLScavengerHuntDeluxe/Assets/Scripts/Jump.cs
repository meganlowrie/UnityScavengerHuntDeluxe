using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // strength of the push
    [Header("Jump Stremgth")]
    public float jumpStrength = 10f;

    [Header("Jump in Midair")]
    public bool alwaysJumping = false;

    private bool canJump;

    private Rigidbody2D rigidBody;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidBody.velocity.y == 0)
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }

        if ((canJump || alwaysJumping) && Input.GetButton("Jump"))
        {
            // Apply an instantaneous upwards force
            rigidBody.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
            //canJump = !checkGround;
        }

    }

}
