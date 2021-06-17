using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
	public GameObject obstacle;
	public float minX;
	public float maxX;
	public float minY;
	public float maxY;
	public float timeToSpawn;
	private float spawnTime;
	
    // Update is called once per frame
    void Update()
    {
		if(Time.time > spawnTime)
		{
			Spawn();
			spawnTime = Time.time + timeToSpawn;
		}
		
    }
	void Spawn()
	{
		float randomX = Random.Range(minX, maxX);
		float randomY = Random.Range(minY, maxY);
		
		Instantiate(obstacle, transform.position + new Vector3(randomX, randomY,0), transform.rotation);
	}
	
}
