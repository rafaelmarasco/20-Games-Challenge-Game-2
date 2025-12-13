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
        StartCoroutine(LaserWarmUp());
        // Show to the player where the laser is going to appear (it needs 2 to 3 secs on screen)
        // set the laser object to visible, then start the coroutine

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator LaserWarmUp()// Makes the exclamation sign desapper after 2.5 secs and the laser appear starting the despawn routine at the same time
    {

        yield return new WaitForSeconds(2.5f);
        // desativar a exclamacao
        Destroy(gameObject.transform.GetChild(1).gameObject);
        StartCoroutine(DespawnLaser());
        
    }


    IEnumerator DespawnLaser()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
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
