using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        if (transform.position.y > 2.6 && directionY == 1 || transform.position.y < -4.3 && directionY == -1)
        {
            playerDirection = new Vector2(0, 0).normalized;
        }
        else
        {
            playerDirection = new Vector2(0, directionY).normalized;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
