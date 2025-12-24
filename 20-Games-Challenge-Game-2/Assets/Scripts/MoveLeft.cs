using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float xLimit = -10f;
    [SerializeField] private float moveSpeed;
    private Vector2 startPos;
    private float repeatOffSet; //Recebe metade do tamanho do box colider (em x)
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameObject.CompareTag("Background"))
        {
            startPos = transform.position;
            repeatOffSet = GetComponent<BoxCollider2D>().size.x / 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Missile"))
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

            if (transform.position.x < xLimit)
            {
                Destroy(gameObject);
            }
        }
        else if (gameObject.CompareTag("Background"))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

            if (transform.position.x < -17.5f)
            {
                transform.position = startPos;
            }
            
        }
    }

}
