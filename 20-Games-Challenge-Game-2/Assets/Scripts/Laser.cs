using System.Collections;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private float xStartPos = 1f;
    private float yRange = 3.5f;
    private float screenTime = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChooseRandomSpawnPos();
        StartCoroutine(DespawnLaser());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator DespawnLaser()
    {
        yield return new WaitForSeconds(screenTime);
        Destroy(gameObject);
    }

    private void ChooseRandomSpawnPos()
    {
        Vector2 randomPos = new Vector2(xStartPos, Random.Range(-yRange, yRange));

        transform.position = randomPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("You took damage!!");
        }

        if (collision.gameObject.CompareTag("Missile"))
        {
            Destroy(collision.gameObject);
        }
    }
}
