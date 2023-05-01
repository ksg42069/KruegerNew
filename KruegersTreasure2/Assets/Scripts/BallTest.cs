using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTest : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject ballSpawn;
    public Transform originalBall;

    public void Fire()
    {
        GameObject spawnedBall = Instantiate(ballSpawn, originalBall);
        spawnedBall.GetComponent<Rigidbody>().velocity = speed * originalBall.forward;

        Destroy(spawnedBall, 1);
    }
}
