using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private Rigidbody2D objectRb;
    public float xLimit = -10f;
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRb = GetComponent<Rigidbody2D>();

        objectRb.AddForce(Vector2.left * moveSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < xLimit)
        {
            Destroy(gameObject);
        }
    }

}
