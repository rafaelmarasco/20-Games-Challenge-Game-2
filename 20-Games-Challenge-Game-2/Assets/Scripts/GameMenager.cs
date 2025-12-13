
using System.Collections;
using UnityEngine;

public class GameMenager : MonoBehaviour
{
    public GameObject missile;
    public GameObject laser;
    private int actualScore = 0;
    private int scorePerSecond = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(SpawnMissileRoutine());
        StartCoroutine(SpawnLaserRoutine());
        StartCoroutine(StartScoreRoutine());

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

    IEnumerator StartScoreRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(scorePerSecond);
            actualScore += scorePerSecond;
            Debug.Log(actualScore);
        }

    }

}
