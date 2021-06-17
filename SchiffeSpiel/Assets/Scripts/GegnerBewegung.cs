using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GegnerBewegung : MonoBehaviour
{
    public float obstacleSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
	private float directionX = 0;
	private float despawningTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		directionX = directionX - 1f;
        playerDirection = new Vector2(directionX, 0).normalized;
		if(Time.time % 5 == 0)
		{
			despawningTime = despawningTime - 0.5f;
		}
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirection.x * obstacleSpeed, 0);
		Destroy(gameObject, despawningTime);
    }
}
