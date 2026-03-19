using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcMovement : MonoBehaviour
{
    GameObject player;
    private float speed = 3f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Orc_Movement();
    }

    private void Orc_Movement()
    {
        Vector2 player_position = player.transform.position;
        Vector2 orc_position = rb.position;

        Vector2 direction = player_position - orc_position;
        Vector2 NormalizeDirection = direction.normalized;

        rb.MovePosition(orc_position + NormalizeDirection * speed * Time.fixedDeltaTime);
        Debug.Log("Orc moving");
    }
}


