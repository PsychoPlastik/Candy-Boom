using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{

    public GameController[] powerUps;
    public int PowerUpsTotal;
    public void SpawnPowerUps()
    {

        if (PowerUpsTotal != 0 ) {
            if (Random.Range(0f, 1f) > 0.5)
            {
                int randomIndex = Random.Range(0, powerUps.Length);
                Instantiate(powerUps[randomIndex], transform.position, Quaternion.identity);
                Debug.Log("spawnou:" + randomIndex);
            }
        }
    }
}
