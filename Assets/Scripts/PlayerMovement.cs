using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Values")]
    public float moveSpeed = 20f;
    public float horizontalMultiplier = 3.5f;
    public Rigidbody rb;
    float horizontalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        TouchMove();
        moveSpeed =moveSpeed+ 0.05f;
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public void TouchMove()
    {
        Vector3 forwardMove = transform.forward * moveSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }


}
