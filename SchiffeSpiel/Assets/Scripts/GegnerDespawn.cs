using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GegnerDespawn : MonoBehaviour
{

    private float despawningTime = 3;
    void Update()
    {
        if (Time.time % 5 == 0)
        {
            despawningTime = despawningTime - 0.5f;
        }
    }
    private void FixedUpdate()
    {
        Destroy(gameObject, despawningTime);
    }
}
