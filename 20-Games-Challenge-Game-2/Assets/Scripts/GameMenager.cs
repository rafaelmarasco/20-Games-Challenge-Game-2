using System.Collections;
using UnityEngine;

public class GameMenager : MonoBehaviour
{
    public GameObject missile;
    private float spawnRate = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnMissileRoutine());
    }

    IEnumerator SpawnMissileRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(missile);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
