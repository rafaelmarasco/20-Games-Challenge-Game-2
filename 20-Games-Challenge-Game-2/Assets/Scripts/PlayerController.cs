using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    [SerializeField] private float flySpeed;
    private float yLitmit = 4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(Vector2.up * flySpeed);
        }

        if (transform.position.y >= yLitmit)
        {   
            float fallSpeed = -(flySpeed + 2);
            transform.position = new Vector2(transform.position.x, yLitmit);
            playerRb.AddForce(Vector2.up * fallSpeed);
        }
    }

}
