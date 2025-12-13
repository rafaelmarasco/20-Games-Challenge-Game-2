
using System.Collections;
using UnityEngine;

public class GameMenager : MonoBehaviour
{
    public GameObject missile;
    public GameObject laser;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnMissileRoutine());
        StartCoroutine(SpawnLaserRoutine());
    }

    IEnumerator SpawnMissileRoutine()
    {
        while (true)
        {
            float spawnRate = Random.Range(1.5f, 4.5f);

            yield return new WaitForSeconds(spawnRate);
            Instantiate(missile);
        }

    }

    IEnumerator SpawnLaserRoutine()
    {
        float spawnRate = 6.0f;

        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(laser);
        }
        
    }

}
