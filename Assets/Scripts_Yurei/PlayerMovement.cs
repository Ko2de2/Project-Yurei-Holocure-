using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 8f;
    private float horizontal;
    private float vertical;
    private bool IsFacingRight = true; // maybe png character usually considered already facing right so make sure to make png picture that is facing right

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Animator _Yurei; // use "_" before name for animator naming?

    private void Start()
    {
        
    }
    void Update() // per frame
    {
        direction();

        //Checking for Walking animation bool
        if (horizontal != 0 || vertical != 0)
        {
            _Yurei.SetBool("isWalking", true);
        }
        else
        {
            _Yurei.SetBool("isWalking", false);
        }

    }

    private void FixedUpdate() // per second
    {
        horizontal = Input.GetAxisRaw("Horizontal"); // left arrow (a) = -1, right arrow (d) = +1
        vertical = Input.GetAxisRaw("Vertical");
        Vector2 Group = new Vector2(horizontal, vertical);
        Vector2 movement = Group.normalized;

        rb.velocity = movement * speed;
    }

    private void direction() //flip the character sprite if it is wrong
    {
        if (IsFacingRight && horizontal < 0f ||
            !IsFacingRight && horizontal > 0f)
        {
            IsFacingRight = !IsFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f; //flip the objects
            transform.localScale = localScale; //apply the new scale
        }
    }

}

