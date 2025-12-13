using UnityEngine;

public class Missile : MonoBehaviour
{
    private float yRange = 3.5f;
    private float xStartPos = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChooseRandomSpawnPos();
    }

    void ChooseRandomSpawnPos()
    {
        Vector2 randomPos = new Vector2(xStartPos, Random.Range(-yRange, yRange));

        transform.position = randomPos;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
